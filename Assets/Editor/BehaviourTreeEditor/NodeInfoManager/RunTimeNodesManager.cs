using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Model
{
    public class RunTimeNodesManager
    {
        private Dictionary<int, RunTimeNodeData> _datas = new Dictionary<int, RunTimeNodeData>();
        private Dictionary<RunTimeNodeData, string> _paramsPath = new Dictionary<RunTimeNodeData, string>();
        private TextNewECtrl _curOpenningCtrl;
        private Dictionary<int, TextNewECtrl> _id2Windows = new Dictionary<int, TextNewECtrl>();
        private List<TextNewECtrl> _ctrls = new List<TextNewECtrl>();
        
        public bool GetTreeWidthFlag(int flag, out RunTimeNodeData data)
        {
            return _datas.TryGetValue(flag, out data);
        }

        public void AddDebugList(int gameObjectId, List<long> pathList)
        {
            RunTimeNodeData data;
            TextNewECtrl ctrl;
            if (!_id2Windows.TryGetValue(gameObjectId, out ctrl))
            {
                return;
            }
            NodeDebugPanel debugPanel = ctrl.DebugPanel;
            if (!debugPanel.IsStop && GetTreeWidthFlag(gameObjectId, out data))
            {
                data.AddDebugList(pathList);
                debugPanel.AddItem(gameObjectId);
            }
        }
        
        private void ClearDebugData()
        {
            foreach (RunTimeNodeData data in _datas.Values)
            {
                data.ClearDebugData();
            }
            _curOpenningCtrl.DebugPanel.Clear();
        }

        public void InitBeTree(NodeProto nodeProto, string path, int flag)
        {
            if (string.IsNullOrEmpty(_curOpenningCtrl.name))
            {
                _curOpenningCtrl.name = path;
            }
            bool isClient = path.EndsWith("prefab");

            int id = flag;
            RunTimeNodeData data = new RunTimeNodeData();
            data.Init(nodeProto, id, isClient, flag);
            _curOpenningCtrl.Canvas.InitBehaviourTree(data.Root);
            _curOpenningCtrl.IncludeIds.Add(id);
            _id2Windows.Add(id, _curOpenningCtrl);
            _datas.Add(id, data);
            _paramsPath.Add(data, path);

            SetNodeShowValue(flag);
        }

        public void SetNodeShowValue(int id)
        {
            _id2Windows[id].Canvas.ForeachNode(node =>
            {
                int index = node.SrcTreeID;
                RunTimeNodeData data = _datas[index];
                NodeParam param = data[node.NodeID];
                node.NodeTypeSet(param);
            });
        }

        public static RunTimeNodesManager Instance { get; private set; }

        [MenuItem("Assets/打开行为树(New)")]
        public static void ShowGo()
        {
            TextNewECtrl window = ScriptableObject.CreateInstance<TextNewECtrl>();
            if (Instance == null)
            {
                Instance = new RunTimeNodesManager();
            }
            InitCtrl(window);

            foreach (GameObject go in Selection.gameObjects)
            {
                string path = AssetDatabase.GetAssetPath(go);
                try
                {
                    BehaviorTreeConfig config = go.GetComponent<BehaviorTreeConfig>();
                    if (config == null)
                    {
                        Log.Debug($"{go.name}不是行为树");
                        continue;
                    }
                    Instance.InitBeTree(config.RootNodeProto, path, go.GetInstanceID());
                    window.SetName(Path.GetFileNameWithoutExtension(path));
                }
                catch (Exception err)
                {
                    BehaviourTreeDebugPanel.Error(Instance._curOpenningCtrl, $"打开行为树失败:{path}-> {err}");
                }
            }
        }

        public static void ShowGo(string path)
        {
            TextNewECtrl window = ScriptableObject.CreateInstance<TextNewECtrl>();
            if (Instance == null)
            {
                Instance = new RunTimeNodesManager();
            }

            InitCtrl(window);
            try
            {
                Instance.CreateNewTree(path);
            }
            catch (Exception err)
            {
                BehaviourTreeDebugPanel.Error(Instance._curOpenningCtrl, $"打开行为树失败:{path}-> {err}");
            }
        }

        private static void InitCtrl(TextNewECtrl window)
        {
            Instance._curOpenningCtrl = window;
            window.OnNodeClick = Instance.OnNodeClick;
            window.OnNodeRightClick = Instance.CanvasRightClick;
            window.OnChildTypeSelected = Instance.AddChild;
            window.OnNodeRemove = Instance.RemoveNode;
            window.NodeSetToChild = Instance.CutAndCopy;
            window.NodeInsert = Instance.Insert;
            window.OnSave = Instance.Save;
            window.SaveToJson = Instance.SaveToJson;
            window.OpenTree = Instance.OpenTree;
            window.Replace = Instance.Replace;
            window.CreateNewTree = Instance.CreateNewTree;
            window.Copy = Instance.Copy;
            window.RecaluOutput = Instance.RecaluOutput;
            window.ResetID = Instance.ResetID;

            window.ShowDebugData = Instance.ShowDebugData;
            window.ClearDebugData = Instance.ClearDebugData;

            window.OnWindowFocus.Add(Instance.SetFocus);
            window.OnDispose.Add(Instance.OnWindowClose);
            Instance._ctrls.Add(window);
            window.SetEvent();
            window.Show();
        }

        private void OnWindowClose(IEditorControl obj)
        {
            TextNewECtrl ctrl = obj as TextNewECtrl;
            foreach (int id in ctrl.IncludeIds)
            {
                _paramsPath.Remove(_datas[id]);
                _datas.Remove(id);
                _id2Windows.Remove(id);
            }
            _ctrls.Remove(ctrl);
        }

        private void LostFocus(EditorControlDialog obj)
        {
            if (_curOpenningCtrl == obj)
            {
                _curOpenningCtrl = null;
            }
        }

        private void SetFocus(EditorControlDialog obj)
        {
            _curOpenningCtrl = obj as TextNewECtrl;
        }

        private void RecaluOutput(int treeID)
        {
            RunTimeNodeData data = _datas[treeID];
            data.InitNodeOutputAvailable();
        }

        private void ShowDebugData(int src, int frame, NodeDebugPanel p)
        {
            var data = _datas[src];
            List<long> frames = data.GetFrame(frame);
            (p.Root as TextNewECtrl).Canvas.ShowDebug(src, frames);
        }

        private void CreateNewTree(string path)
        {
            GameObject go = AssetDatabase.LoadAssetAtPath<GameObject>(path);
            if (go == null)
            {
                OpenTree(path);
            }
            else
            {
                InitBeTree(go.GetComponent<BehaviorTreeConfig>().RootNodeProto, path, go.GetInstanceID());
            }
        }

        private void Replace(BeTreeNode arg1, Type arg2)
        {
            RunTimeNodeData data = _datas[arg1.SrcTreeID];
            data.Replace(arg1.NodeID, arg2);
            SetNodeShowValue(data.ID);
        }

        private void OpenTree(string path)
        {
            using (StreamReader rd = new StreamReader(path))
            {
                string text = rd.ReadToEnd();
                try
                {
	                string fileName = Path.GetFileNameWithoutExtension(path);
                    Instance.InitBeTree(MongoHelper.FromJson<NodeProto>(text), path, fileName.GetHashCode());
                }
                catch (Exception err)
                {
                    BehaviourTreeDebugPanel.Error(_curOpenningCtrl, $"打开行为树失败:{path}-> {err}");
                }
            }
        }

        private void Save()
        {
            foreach (var pair in _datas)
            {
                string path = _paramsPath[pair.Value];
                bool isClient = !path.Contains(".txt");
                RunTimeNodeData data = pair.Value;

                GameObject go;
                GameObject repGo = null;
                bool saveType = data.Save(out go);
                if (!saveType)
                {
                    continue;
                }

                GameObject src = new GameObject(pair.Value.Root.NodeDesc);

                if (isClient)
                {
                    repGo = AssetDatabase.LoadAssetAtPath<GameObject>(path);
                    src = PrefabUtility.ConnectGameObjectToPrefab(src, repGo);
                    UnityEngine.Object.DestroyImmediate(src.transform.GetChild(0).gameObject, true);
                }
                go.transform.SetParent(src.transform);

                var tree = src.GetComponent<BehaviorTreeConfig>() ?? src.AddComponent<BehaviorTreeConfig>();
                tree.RootNodeConfig = go.GetComponent<BehaviorNodeConfig>();

                if (path.Contains(".txt"))
                {
                    BehaviourTreeJsonHelper.WriteToJson(tree, path);
                }
                else
                {
                    //src = PrefabUtility.ConnectGameObjectToPrefab(src, repGo);
                    PrefabUtility.ReplacePrefab(src, repGo, ReplacePrefabOptions.ConnectToPrefab);
                    EditorUtility.SetDirty(repGo);
                    //AssetDatabase.SaveAssets();
                }
                UnityEngine.Object.DestroyImmediate(src);
                BehaviourTreeDebugPanel.Log(_curOpenningCtrl, "保存成功");
            }
        }

        private void SaveToJson()
        {
            foreach (var pair in _datas)
            {
                string path = _paramsPath[pair.Value];

                RunTimeNodeData data = pair.Value;
                GameObject go;
                if (!data.Save(out go))
                {
                    continue;
                }

                GameObject src = new GameObject(pair.Value.Root.NodeDesc);
                go.transform.SetParent(src.transform);

                var tree = src.AddComponent<BehaviorTreeConfig>();
                tree.RootNodeConfig = go.GetComponent<BehaviorNodeConfig>();
                BehaviourTreeJsonHelper.WriteToJson(tree, path);

                UnityEngine.Object.DestroyImmediate(src);
            }
        }

        private void Insert(BeTreeNode src, BeTreeNode insert)
        {
            if (insert.SrcTreeID != src.SrcTreeID)
            {
                return;
            }
            RunTimeNodeData data = _datas[src.SrcTreeID];
            data.Insert(data.GetNodeParam(src.NodeID), data.GetNodeParam(insert.NodeID));
            _curOpenningCtrl.Canvas.RefreshNodeParam(data.Root);
            SetNodeShowValue(data.ID);
        }

        private void ResetID()
        {
            foreach (RunTimeNodeData data in _datas.Values)
            {
                data.ResetID();
                _curOpenningCtrl.Canvas.RefreshNodeParam(data.Root);
                SetNodeShowValue(data.ID);
            }
        }

        private void Copy(BeTreeNode arg1, BeTreeNode arg2)
        {
            RunTimeNodeData data1 = _datas[arg1.SrcTreeID];
            RunTimeNodeData data2 = _datas[arg2.SrcTreeID];

            NodeParam root = data1.GetNodeParam(arg1.NodeID);
            NodeParam copy = data2.GetNodeParam(arg2.NodeID);

            if (!data1.CopyChild(root, copy))
            {
                return;
            }

            if (data1 == data2)
            {
                _id2Windows[data1.ID].Canvas.RefreshNodeParam(data1.Root);
                SetNodeShowValue(data1.ID);
            }
            else
            {
                _id2Windows[data1.ID].Canvas.RefreshNodeParam(data1.Root);
                _id2Windows[data2.ID].Canvas.RefreshNodeParam(data2.Root);
                SetNodeShowValue(data1.ID);
                SetNodeShowValue(data2.ID);
            }
        }

        private void CutAndCopy(BeTreeNode arg1, BeTreeNode arg2)
        {
            RunTimeNodeData data1 = _datas[arg1.SrcTreeID];
            RunTimeNodeData data2 = _datas[arg2.SrcTreeID];

            NodeParam root = data1.GetNodeParam(arg1.NodeID);
            NodeParam copy = data2.GetNodeParam(arg2.NodeID);

            if (!data1.CopyChild(root, copy))
            {
                return;
            }
            data2.DeleteNode(copy.NodeID);

            if (data1 == data2)
            {
                _id2Windows[data1.ID].Canvas.RefreshNodeParam(data1.Root);
                SetNodeShowValue(data1.ID);
            }
            else
            {
                _id2Windows[data1.ID].Canvas.RefreshNodeParam(data1.Root);
                _id2Windows[data2.ID].Canvas.RefreshNodeParam(data2.Root);
                SetNodeShowValue(data1.ID);
                SetNodeShowValue(data2.ID);
            }
        }

        private void CanvasRightClick(BeTreeNode e, bool isAdd)
        {
            RunTimeNodeData data = _datas[e.SrcTreeID];
            List<NodeParam> allParam = NodeInfoManager.GetAllParam(data.IsClient);
            NodeParam srcNodeParam = data[e.NodeID];
            NodeClassifyType classfiy = srcNodeParam.NodeClassType;
            List<NodeParam> ps = new List<NodeParam>();
            foreach (NodeParam param in allParam)
            {
                switch (classfiy)
                {
                    case NodeClassifyType.Action:
                    case NodeClassifyType.Condition:
                    case NodeClassifyType.DataTransform:
                    case NodeClassifyType.Error:
                        if (!isAdd)
                        {
                            if (param.NodeClassType != NodeClassifyType.Root)
                            {
                                ps.Add(param);
                            }
                        }
                        break;
                    case NodeClassifyType.Composite:
                    case NodeClassifyType.Decorator:
                        if (!isAdd)
                        {
                            if (param.NodeClassType == NodeClassifyType.Decorator || param.NodeClassType == NodeClassifyType.Composite)
                            {
                                ps.Add(param);
                            }
                        }
                        else
                        {
                            if (param.NodeClassType != NodeClassifyType.Root)
                            {
                                ps.Add(param);
                            }
                        }
                        break;
                    case NodeClassifyType.Root:
                        if (isAdd)
                        {
                            if (param.NodeClassType != NodeClassifyType.Root)
                            {
                                ps.Add(param);
                            }
                        }
                        else
                        {
                            if (param.NodeClassType == NodeClassifyType.Root)
                            {
                                ps.Add(param);
                            }
                        }
                        break;
                }
            }

            _curOpenningCtrl.Canvas.ShowAddNodePanel(e, ps.ToArray(), isAdd);
        }

        private void OnNodeClick(BeTreeNode node)
        {
            int index = node.SrcTreeID;
            RunTimeNodeData data = _datas[index];
            NodeParam param = data.GetNodeParam(node.NodeID);
            _curOpenningCtrl.Canvas.ShowDetialPanel(param, data.GetParamOutput(param));
        }

        private void AddChild(BeTreeNode rootNode, Type childType)
        {
            RunTimeNodeData data = _datas[rootNode.SrcTreeID];
            data.AddChild(rootNode.NodeID, childType);
            _id2Windows[data.ID].Canvas.RefreshNodeParam(data.Root);
            SetNodeShowValue(data.ID);
        }

        private void RemoveNode(BeTreeNode node)
        {
            RunTimeNodeData data = _datas[node.SrcTreeID];
            data.DeleteNode(node.NodeID);
            _id2Windows[data.ID].Canvas.RefreshNodeParam(data.Root);
            SetNodeShowValue(data.ID);
        }
    }
}

using ServerTree;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Model
{
    public class RunTimeNodeData
    {
        private Dictionary<int, NodeParam> _id2Node = new Dictionary<int, NodeParam>();
        private Dictionary<NodeParam, NodeParamIOData> _infoDatas = new Dictionary<NodeParam, NodeParamIOData>();
        private List<List<long>> _debugList = new List<List<long>>();
        private int _flag;
        public int ID => _flag;
        private NodeParam _root;
        public NodeParam Root => _root;

        public bool IsClient => _isClient;

        private int _treeID;
        private int _maxID = 0;
        private bool _isClient;

        public bool Match(int value)
        {
            return _flag == value;
        }

        public void Init(NodeProto rootProto, int startID, bool isClient, int flag)
        {
            _flag = flag;
            _isClient = isClient;
            _treeID = startID;
            Queue<NodeProto> queue = new Queue<NodeProto>();
            queue.Enqueue(rootProto);
            Dictionary<NodeProto, NodeParam> _parents = new Dictionary<NodeProto, NodeParam>();
            while (queue.Count > 0)
            {
                NodeProto p = queue.Dequeue();
                Type nodeType;
                if (_isClient)
                {
                    nodeType = typeof(Node).Assembly.GetType($"Model.{p.Name}");
                }
                else
                {
                    nodeType = typeof(ServerTreeNodeTest).Assembly.GetType($"ServerTree.{p.Name}");
                }
                NodeParam param;
                if (nodeType == null)
                {
                    param = CreateEmptyNode(p.Id);
                }
                else
                {
                    param = CreateNodeParam(nodeType, p.Id);
                }

                foreach (ParamInfo info in param.Fields)
                {
                    info.DefaultValue = p.Args.Get(info.FieldName);
                }

                foreach (ParamInfoInput input in param.Inputs)
                {
                    input.SrcInputStr = p.Args.Get(input.InputFieldName) as string;
                }

                foreach (ParamInfoOutput output in param.Outputs)
                {
                    output.OutputName = p.Args.Get(output.OutputFieldName) as string;
                }
                
                param.NodeDesc = p.Desc;
                if (_parents.ContainsKey(p))
                {
                    param.SetParent(_parents[p]);
                }
                else
                {
                    _root = param;
                }
                _maxID = Mathf.Max(p.Id, _maxID);
                foreach (NodeProto child in p.Children)
                {
                    _parents.Add(child, param);
                    queue.Enqueue(child);
                }
            }

            InitNodeOutputAvailable();
        }

        #region 节点创建与删除
        private NodeParam CreateNodeParam(Type nodeType, int nodeID)
        {
            NodeParam param = NodeInfoManager.GetNodeParam(nodeType, nodeID, _treeID, _isClient);
            _id2Node.Add(nodeID, param);
            return param;
        }

        private NodeParam CreateEmptyNode(int nodeID)
        {
            NodeParam param = NodeInfoManager.GetErrorParam(nodeID, _treeID);
            _id2Node.Add(nodeID, param);
            return param;
        }

        private NodeParam CreateNodeParam(Type nodeType)
        {
            int nodeID = ++_maxID;
            NodeParam param = NodeInfoManager.GetNodeParam(nodeType, nodeID, _treeID, _isClient);
            _id2Node.Add(nodeID, param);
            return param;
        }

        private void RemoveNode(int id)
        {
            NodeParam node = _id2Node[id];
            Queue<NodeParam> queue = new Queue<NodeParam>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                NodeParam n = queue.Dequeue();
                n.SetParent(null);
                _id2Node.Remove(n.NodeID);
                foreach (NodeParam child in n.ChildrenList)
                {
                    queue.Enqueue(child);
                }
            }
            node.SetParent(null);
        }
        #endregion

        public void ResetID()
        {
            _maxID = 100000;
            List<NodeParam> values = new List<NodeParam>(_id2Node.Values);
            _id2Node.Clear();
            foreach (NodeParam p in values)
            {
                p.NodeID = ++_maxID;
                _id2Node.Add(p.NodeID, p);
            }
        }

        public NodeParam this[int id]
        {
            get { return _id2Node[id]; }
        }

        public NodeParam GetNodeParam(int id)
        {
            return _id2Node[id];
        }

        private NodeParam NodeParamClone(NodeParam src)
        {
            NodeParam p = new NodeParam()
            {
                NodeType = src.NodeType,
                NodeDesc = src.NodeDesc,
                NodeClassType = src.NodeClassType,
                Parent = src.Parent,
                NodeID = ++_maxID,
                SrcTreeID = _treeID
            };

            foreach (ParamInfo pi in src.Fields)
            {
                p.Fields.Add(pi.Clone());
            }

            foreach (ParamInfoOutput pi in src.Outputs)
            {
                p.Outputs.Add(pi.Clone(p));
            }

            foreach (ParamInfoInput input in src.Inputs)
            {
                p.Inputs.Add(input.Clone());
            }

            _id2Node.Add(p.NodeID, p);
            foreach (NodeParam child in src.ChildrenList)
            {
                NodeParam cloneChild = NodeParamClone(child);
                cloneChild.SetParent(p);
            }
            return p;
        }

        public void InitNodeOutputAvailable()
        {
            _infoDatas.Clear();
            NodeParamIOData initData = new NodeParamIOData();
            Stack<NodeParam> nodeStack = new Stack<NodeParam>();
            nodeStack.Push(_root);

            while (nodeStack.Count > 0)
            {
                NodeParam node = nodeStack.Pop();

                foreach (ParamInfoInput input in node.Inputs)
                {
                    List<ParamInfoOutput> ps = initData[input.InputType];
                    if (ps == null || input.Input != null && !ps.Contains(input.Input))
                    {
                        input.Input = null;
                    }

                    if (!string.IsNullOrEmpty(input.SrcInputStr) && input.Input == null)
                    {
                        foreach (var p in ps)
                        {
                            if (p.OutputName == input.SrcInputStr)
                            {
                                input.Input = p;
                                break;
                            }
                        }
                    }
                }

                _infoDatas.Add(node, initData.Clone());

                foreach (ParamInfoOutput paramInfo in node.Outputs)
                {
                    initData.AddParam(paramInfo.OutputType, paramInfo);
                }

                for (int i = node.ChildrenList.Count - 1; i >= 0; --i)
                {
                    nodeStack.Push(node.ChildrenList[i]);
                }
            }
        }

        public List<ParamInfoOutput> GetParamOutputWithType(NodeParam p, Type t)
        {
            return _infoDatas[p][t];
        }

        public NodeParamIOData GetParamOutput(NodeParam node)
        {
            return _infoDatas[node];
        }

        public void AddChild(int nodeID, Type childType)
        {
            NodeParam param = CreateNodeParam(childType);
            NodeParam parent = _id2Node[nodeID];
            param.SetParent(parent);
            InitNodeOutputAvailable();
        }

        public void DeleteNode(int nodeID)
        {
            NodeParam node = _id2Node[nodeID];
            if (node == _root)
            {
                return;
            }
            RemoveNode(nodeID);

            InitNodeOutputAvailable();
        }

        public bool CopyChild(NodeParam newRoot, NodeParam target)
        {
            NodeParam rootParent = newRoot.Parent;
            NodeClassifyType rootType = newRoot.NodeClassType;
            if (rootType == NodeClassifyType.Action || rootType == NodeClassifyType.Condition || rootType == NodeClassifyType.DataTransform)
            {
                return false;
            }
            while (rootParent != null)
            {
                if (rootParent == target)
                {
                    return false;
                }
                rootParent = rootParent.Parent;
            }

            NodeParam newNode = NodeParamClone(target);
            newNode.SetParent(newRoot);
            InitNodeOutputAvailable();

            return true;
        }

        public bool Insert(NodeParam node, NodeParam insertNode)
        {
            if (insertNode.Parent != node.Parent || insertNode.Parent == null)
            {
                return false;
            }

            int index = node.Parent.ChildrenList.IndexOf(node);
            insertNode.InsertParent(insertNode.Parent, index);
            InitNodeOutputAvailable();
            return true;
        }

        public bool Replace(int srcNodeID, Type rpType)
        {
            NodeParam param = _id2Node[srcNodeID];
            NodeParam rpParam = NodeInfoManager.GetNodeParam(rpType, 0, 0, _isClient);
            param.Replace(rpParam);
            return true;
        }
        #region Debug
        public void AddDebugList(List<long> frame)
        {
            _debugList.Add(frame);
        }

        public List<long> GetFrame(int frame)
        {
            return _debugList[frame];
        }

        public int FrameCount { get { return _debugList.Count; } }

        public void ClearDebugData()
        {
            _debugList.Clear();
        }
        #endregion

        #region 保存
        public bool Save(out GameObject saveGo)
        {
            saveGo = null;
            if (!SaveCheck())
            {
                return false;
            }
            NodeParam root = _root;
            Queue<NodeParam> paramQueue = new Queue<NodeParam>();
            Dictionary<NodeParam, GameObject> parentGoes = new Dictionary<NodeParam, GameObject>();
            GameObject goRoot = null;
            paramQueue.Enqueue(root);
            while (paramQueue.Count > 0)
            {
                NodeParam p = paramQueue.Dequeue();
                GameObject go = new GameObject();

                GameObject parent;
                if (!parentGoes.TryGetValue(p, out parent))
                {
                    goRoot = go;
                }
                else
                {
                    go.transform.SetParent(parent.transform);
                }

                BehaviorNodeConfig nodeConfig = go.AddComponent<BehaviorNodeConfig>();
                nodeConfig.id = p.NodeID;
                nodeConfig.name = p.NodeType.Name;
                go.name = nodeConfig.name;
                nodeConfig.describe = p.NodeDesc;

                foreach (ParamInfo param in p.Fields)
                {
                    string key = param.FieldName;
                    object value = param.DefaultValue;
                    AddComponentToGameObject(param.ParamType, go, key, value);
                }

                foreach (ParamInfoInput input in p.Inputs)
                {
                    string key = input.InputFieldName;
                    if (input.Input == null)
                    {
                        continue;
                    }
                    string value = input.Input.OutputName;
                    AddComponentToGameObject(typeof(string), go, key, value);
                }

                foreach (ParamInfoOutput op in p.Outputs)
                {
                    string key = op.OutputFieldName;
                    string value = op.OutputName;
                    AddComponentToGameObject(typeof(string), go, key, value);
                }

                foreach (NodeParam child in p.ChildrenList)
                {
                    paramQueue.Enqueue(child);
                    parentGoes.Add(child, go);
                }
            }
            saveGo = goRoot;
            return true;
        }

        private bool SaveCheck()
        {
            Queue<NodeParam> queue = new Queue<NodeParam>();
            queue.Enqueue(Root);
            while (queue.Count > 0)
            {
                NodeParam p = queue.Dequeue();
                foreach (var input in p.Inputs)
                {
                    if (input.Input == null)
                    {
                        BehaviourTreeDebugPanel.Error($"{p.NodeID}的输入不能为空");
                        return false;
                    }
                }

                foreach (var child in p.ChildrenList)
                {
                    queue.Enqueue(child);
                }
            }
            return true;
        }

        private void AddComponentToGameObject(Type type, GameObject go, string key, object value)
        {
            try
            {
                Type compType = GoNodeTypeManager.GetBTType(type);
                UnityEngine.Component comp = go.AddComponent(compType);
                compType.GetField("fieldName").SetValue(comp, key);
                if (TypeHelper.IsEnumType(type))
                {
                    value = value.ToString();
                }
                compType.GetField("fieldValue").SetValue(comp, value);
            }
            catch (Exception err)
            {
                throw new Exception($"Transform failed. {type}, {key}, {value}", err);
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Model
{
    public class TextNewECtrl : EditorControlDialog
    {
        public List<int> IncludeIds = new List<int>();
        public TreeNodeCanvas Canvas;
        public NodeDebugPanel DebugPanel;
        public EditorToolBar ToolBar;
        public NodeToolPanel SearchPanel;
        public BehaviourTreeDebugPanel BTreeDebugPanel;

        public Action<BeTreeNode> OnNodeClick;
        public Action<BeTreeNode, bool> OnNodeRightClick;
        public Action<BeTreeNode, Type> OnChildTypeSelected;
        public Action<BeTreeNode> OnNodeRemove;
        public Action<BeTreeNode, BeTreeNode> NodeSetToChild;
        public Action<BeTreeNode, BeTreeNode> NodeInsert;
        public Action OnSave;
        public Action SaveToJson;
        public Action<string> OpenTree;
        public Action<BeTreeNode, Type> Replace;
        public Action<string> CreateNewTree;
        public Action<BeTreeNode, BeTreeNode> Copy;
        public Action<int> RecaluOutput;
        public Action<int, int, NodeDebugPanel> ShowDebugData;
        public Action ClearDebugData;
        public Action ResetID;

        public override void Start()
        {
            base.Start();
            minSize = new Vector2(300, 300);
            
            EditorPopupMenu mainPopup = NodeFactoryXML.CreateEditorControl<EditorPopupMenu>();
            mainPopup.AddMenu("Save", obj => OnSave?.Invoke());
            mainPopup.AddMenu("Open", obj => OpenPanel());
            mainPopup.AddMenu("Create（Server）", obj => CreatePanel("txt"));
            mainPopup.AddMenu("Create（Client）", obj => CreatePanel("prefab"));
            ToolBar.AddItem("Files", mainPopup);

            EditorPopupMenu searchPop = NodeFactoryXML.CreateEditorControl<EditorPopupMenu>();
            searchPop.AddMenu("Open search panel", obj => SearchPanel.Active = true);
            searchPop.AddMenu("Close search panel", obj => SearchPanel.Active = false);
            ToolBar.AddItem("Search", searchPop);

            EditorPopupMenu debugPop = NodeFactoryXML.CreateEditorControl<EditorPopupMenu>();
            debugPop.AddMenu("Pause", obj => DebugPanel.IsStop = true);
            debugPop.AddMenu("Resume", obj => DebugPanel.IsStop = false);
            debugPop.AddMenu("Clear", obj => DebugPanel.TryClear());
            ToolBar.AddItem("Debug", debugPop);

            EditorPopupMenu configPop = NodeFactoryXML.CreateEditorControl<EditorPopupMenu>();
            configPop.AddMenu("Reset ID", obj => ResetID?.Invoke());
            configPop.AddMenu("Open config panel", obj => GetWindow<TreeConfigPanel>());
            configPop.AddMenu("Search node", obj => GetWindow<TreeSearchPanel>());
            configPop.AddMenu("Change node", obj => GetWindow<NodeReplacePanel>());
            ToolBar.AddItem("Tool&Config", configPop);

            SearchPanel.OnSearch = SearchParam;
            SearchPanel.LocationNode = LocateNode;
        }

        private void LocateNode(BeTreeNode obj)
        {
            Canvas.PointToNode(obj.SrcTreeID, obj.NodeID);
        }

        private void SearchParam(string key)
        {
            List<BeTreeNode> bList = new List<BeTreeNode>();
            foreach (BeTreeNode btn in Canvas.NodeList.Values)
            {
                Queue<BeTreeNode> btnQueue = new Queue<BeTreeNode>();
                btnQueue.Enqueue(btn);
                while (btnQueue.Count > 0)
                {
                    BeTreeNode node = btnQueue.Dequeue();

                    key = key.ToLower();
                    if (node.NodeID.ToString().Contains(key))
                    {
                        bList.Add(node);
                    }
                    else if (node.TypeName.Content != null && node.TypeName.Content.ToString().ToLower().Contains(key))
                    {
                        bList.Add(node);
                    }
                    else if (node.TypeDesc.Content != null && node.TypeDesc.Content.ToString().ToLower().Contains(key))
                    {
                        bList.Add(node);
                    }

                    foreach (BeTreeNode child in node.NodeChildren)
                    {
                        btnQueue.Enqueue(child);
                    }
                }
            }

            SearchPanel.ShowData(bList);
        }

        private void OpenPanel()
        {
            string str = EditorUtility.OpenFilePanelWithFilters("打开Json行为树", EditorTreeConfigHelper.Instance.Config.ServersPath, new string[] { "Json File", "txt" });
            if (!string.IsNullOrEmpty(str))
            {
                OpenTree?.Invoke(str);
                SetName(Path.GetFileNameWithoutExtension(str));
            }
        }

        private void CreatePanel(string exName)
        {
            string path;
            if (TreeCreatorHelper.CreateNewTree(exName, out path))
            {
                CreateNewTree?.Invoke(path);
                SetName(exName);
            }
        }

        public void SetName(string name)
        {
            GUIContent content = new GUIContent()
            {
                text = name
            };
            titleContent = content;
        }

        public void SetEvent()
        {
            Canvas.OnNodeClick = OnNodeClick;
            Canvas.OnNodeRightClick = OnNodeRightClick;
            Canvas.OnChildTypeSelected = OnChildTypeSelected;
            Canvas.OnNodeRemove = OnNodeRemove;
            Canvas.NodeSetToChild = NodeSetToChild;
            Canvas.NodeInsert = NodeInsert;
            Canvas.OnSave = OnSave;
            Canvas.OnSaveToJson = SaveToJson;
            Canvas.OnOpenTree = OpenTree;
            Canvas.OnReplace = Replace;
            Canvas.OnCreateNewTree = CreateNewTree;
            Canvas.CopyChildEvent = Copy;
            Canvas.OnOutputNameChange = RecaluOutput;
            Canvas.ResetID = ResetID;

            DebugPanel.FrameSelected = ShowDebugData;
            DebugPanel.OnClearClick = ClearDebugData;
        }
    }
}

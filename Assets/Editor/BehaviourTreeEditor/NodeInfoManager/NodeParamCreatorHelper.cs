using System.Collections.Generic;

namespace Model
{
    public static class NodeParamCreatorHelper
    {
        private static Dictionary<int, BeTreeNode> _dict;
        private static TreeNodeCanvas _canvas;

        /// <summary>
        /// 创建一个节点（没有层级关系）
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        private static BeTreeNode CreateBTN(this NodeParam param)
        {
            BeTreeNode btn = NodeFactoryXML.CreateEditorControl<BeTreeNode>();
            btn.SrcTreeID = param.SrcTreeID;
            btn.NodeID = param.NodeID;
            btn.ChildrenShow = param.IsShowChild;
            btn.Active = param.IsShow;
            _dict.Add(btn.NodeID, btn);
            return btn;
        }

        private static void DeployNodeEvent(this BeTreeNode node)
        {
            node.OnMouseClick.Add(_canvas.ShowNodeDetial);
            node.OnRightClick.Add((b, e) =>
            {
                _canvas.SetSelectedShow(b as BeTreeNode);
                e.Use();
            });
            node.OnMouseDown.Add(_canvas.StartDrag);
            node.OnDragOut.Add(_canvas.StopDrog);
            node.OnDragIn.Add(_canvas.DropIn);
            node.Context = NodeRightClickPanel(node);
            node.OnChildrenShowStateChange = _canvas.ReCalculateNode;
        }

        private static void RemoveBTN(this BeTreeNode btn)
        {
            btn.Dispose();
            _dict.Remove(btn.NodeID);
        }

        /// <summary>
        /// 刷新一个节点（没有层级关系）
        /// </summary>
        /// <param name="node"></param>
        /// <param name="param"></param>
        public static void RefreshBTNWithParam(this BeTreeNode node, NodeParam param)
        {
            _dict.Remove(node.NodeID);
            node.SrcTreeID = param.SrcTreeID;
            node.NodeID = param.NodeID;
            _dict.Add(node.NodeID, node);
        }

        public static BeTreeNode CreateTree(NodeParam root, TreeNodeCanvas canvas, Dictionary<int, BeTreeNode> dict)
        {
            _canvas = canvas;
            _dict = dict;

            List<int> ids = new List<int>(dict.Keys);
            foreach (int id in ids)
            {
                dict[id].RemoveBTN();
            }

            Queue<NodeParam> queue = new Queue<NodeParam>();
            queue.Enqueue(root);
            BeTreeNode rootNode = null;
            while (queue.Count > 0)
            {
                NodeParam p = queue.Dequeue();
                BeTreeNode pBtn = p.CreateBTN();
                pBtn.DeployNodeEvent();
                if (p.Parent == null)
                {
                    rootNode = pBtn;
                    rootNode.SetParent(canvas.NodePanels);
                }
                else
                {
                    dict[p.Parent.NodeID].AddChild(pBtn, _canvas.NodePanels);
                }

                foreach (NodeParam child in p.ChildrenList)
                {
                    queue.Enqueue(child);
                }
            }

            return rootNode;
        }

        public static EditorPopupMenu NodeRightClickPanel(BeTreeNode node)
        {
            EditorPopupMenu menu = NodeFactoryXML.CreateEditorControl<EditorPopupMenu>();
            menu.AddMenu("Copy", obj => _canvas.CopyItem(node));
            menu.AddMenu("Paste", obj => _canvas.PasteItem(node));
            menu.AddMenu("Delete", obj => _canvas.DeleteItem(node));
            menu.AddMenu("Create sub node", obj => _canvas.ShowExPanel(node));
            menu.AddMenu("Change node", obj => _canvas.ShowExPanelExchange(node));
            return menu;
        }
    }
}

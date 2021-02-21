using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Model
{
    public class TreeNodeCanvas : EditorControl
    {
        public Vector2 NodeScale = new Vector2(0, 10);
        public EditorImage NodePanels;
        private Vector2 _canvasOffset = new Vector2();
        public Dictionary<int, BeTreeNode> NodeList = new Dictionary<int, BeTreeNode>();
        public NodeDataInfoPanel DetialPanel;

        public EditorImage DetialBackground;
        public Action<BeTreeNode> OnNodeClick;
        public NodeLinkCanvas LinkCanvas;

        public EditorImage NodeOutputSrc;

        public NodeFilterPanel NodeSelectedPanel;
        public Action<BeTreeNode, bool> OnNodeRightClick;
        public Action<BeTreeNode, Type> OnChildTypeSelected;
        public Action<BeTreeNode> OnNodeRemove;
        public Action<BeTreeNode, BeTreeNode> NodeSetToChild;
        public Action<BeTreeNode, BeTreeNode> NodeInsert;
        public Action OnSave;
        public Action OnSaveToJson;
        public Action<string> OnOpenTree;
        public Action<BeTreeNode, Type> OnReplace;
        public Action<string> OnCreateNewTree;
        public Action<BeTreeNode, BeTreeNode> CopyChildEvent;
        public Action<int> OnOutputNameChange;
        public Action ResetID;

        private NodeDragType _isChildDrag = NodeDragType.None;
        
        private Dictionary<int, Dictionary<int, BeTreeNode>> _srcNode = new Dictionary<int, Dictionary<int, BeTreeNode>>();
        private bool _down;

        private EditorControl _dragingNode;
        private Vector2 _mouseOffset;

        private static BeTreeNode _copyNode;

        public TreeNodeCanvas()
        {
            OnMouseClick.Add(MouseClick);
            OnMouseDown.Add((k, e) =>
            {
                if (e.Event.button == 2 || e.Event.button == 1)
                {
                    _down = true;
                }
            });

            OnMouseUp.Add((k, e) =>
            {
                if (e.Event.button == 2 || e.Event.button == 1)
                {
                    _down = false;
                }
            });
            OnKeyDown.Add((k, e) =>
            {
                switch (e.Event.keyCode)
                {
                    case KeyCode.Delete:
                        BeTreeNode node = _curSelected;
                        if (_curSelected == null)
                        {
                            return;
                        }
                        DeleteItem(node);
                        break;
                    case KeyCode.Escape:
                        if (_curSelected != null)
                        {
                            SelectedNode(null);
                            break;
                        }
                        if (EditorUtility.DisplayDialog("Close window", "You will lose all the unsafed data.", "Confirm", "Cancel"))
                        {
                            (Root as EditorWindow).Close();
                        }
                        break;
                    case KeyCode.S:
                        if (e.Event.control)
                        {
                            if (e.Event.alt)
                            {
                                OnSaveToJson?.Invoke();
                            }
                            else
                            {
                                OnSave?.Invoke();
                            }
                        }
                        break;
                    case KeyCode.O:
                        if (e.Event.control && e.Event.alt)
                        {
                            OpenPanel();
                        }
                        break;
                    case KeyCode.N:
                        if (e.Event.control && e.Event.alt)
                        {
                            if (!e.Event.shift)
                            {
                                CreatePanel("prefab");
                            }
                            else
                            {
                                CreatePanel("txt");
                            }
                        }
                        break;
                }
            });
        }

        #region 原快捷键操作
        public void CopyItem(BeTreeNode node)
        {
            _copyNode = node;
        }

        public void PasteItem(BeTreeNode parent)
        {
            if (_copyNode == null)
            {
                return;
            }
            CopyChildEvent?.Invoke(parent, _copyNode);
        }

        public void DeleteItem(BeTreeNode node)
        {
            if (EditorUtility.DisplayDialog("Delete node", "Are you sure to delete selecting node?", "Confirm", "Cancel"))
            {
                OnNodeRemove?.Invoke(node);
                SelectedNode(null);
                DetialPanel.Hide();
                NodeSelectedPanel.Active = false;
            }
        }

        public void SetSelectedShow(BeTreeNode b)
        {
            if (_dragingNode != null)
            {
                return;
            }

            SelectedNode(b);
        }
        #endregion

        #region 调试处理
        private Dictionary<int, List<long>> _debugList = new Dictionary<int, List<long>>();
        public void ShowDebug(int src, List<long> frames)
        {
            SetDebugType(false);
            _debugList.Add(src, frames);
            SetDebugType(true);
        }

        private void SetDebugType(bool state)
        {
            foreach (var pair in _debugList)
            {
                foreach (long id in _debugList[pair.Key])
                {
                    _srcNode[pair.Key][(int)id].SetDebug(state);
                }
            }

            if (!state)
            {
                _debugList.Clear();
            }
        }
        #endregion

        private void CreatePanel(string exName)
        {
            string path;
            if (TreeCreatorHelper.CreateNewTree(exName, out path))
            {
                OnCreateNewTree?.Invoke(path);
            }
        }

        private void OpenPanel()
        {
            string str = EditorUtility.OpenFilePanelWithFilters("Open JSON behaviour tree", EditorTreeConfigHelper.Instance.Config.ServersPath, new string[] { "Json File", "txt" });
            if (!string.IsNullOrEmpty(str))
            {
                OnOpenTree?.Invoke(str);
            }
        }

        public override void InitFinish()
        {
            base.InitFinish();
            NodeSelectedPanel.OnAddSelected = (type) =>
            {
                OnChildTypeSelected?.Invoke(_curSelected, type);
                SelectedNode(null);
            };

            NodeSelectedPanel.OnChangeSelected = type =>
            {
                OnReplace?.Invoke(_curSelected, type);
            };

            DetialPanel.OnDataChange = () =>
            {
                _curSelected.NodeTypeSet(_curSelected.ParamData);
                ClearOutputShow();
                SetOutputShow();
            };

            DetialPanel.OnOutputNameChange = () =>
            {
                OnOutputNameChange?.Invoke(_curSelected.SrcTreeID);
            };
        }

        protected override void Draw()
        {
            if (_down)
            {
                Vector2 delta = Event.current.delta;
                NodePanels.LocalPosition += delta;
                DetialPanel.LocalPosition += delta;
                DetialBackground.LocalPosition += delta;
                NodeSelectedPanel.LocalPosition += delta;
            }

            if (_dragingNode != null)
            {
                _dragingNode.LocalPosition = Event.current.mousePosition - NodePanels.LocalPosition - _mouseOffset;
                SetLine();
            }

            base.Draw();
        }

        #region 节点生成
        public void InitBehaviourTree(NodeParam param)
        {
            Dictionary<int, BeTreeNode> id2Node;
            if (!_srcNode.TryGetValue(param.SrcTreeID, out id2Node))
            {
                id2Node = new Dictionary<int, BeTreeNode>();
                _srcNode.Add(param.SrcTreeID, id2Node);
            }
            BeTreeNode node = NodeParamCreatorHelper.CreateTree(param, this, id2Node);
            NodeList.Add(node.SrcTreeID, node);
            ReCalculateNode();
        }

        #region 拖拽事件
        public void StopDrog(EditorControl arg1, EditorEvent arg2, IEditorSeletable arg3)
        {
            if (arg3 == this)
            {
                ReCalculateNode();
                _dragingNode = null;
                arg2.Use();
            }
        }

        public void DropIn(EditorControl root1, EditorEvent e, IEditorSeletable node1)
        {
            BeTreeNode node = node1 as BeTreeNode;
            BeTreeNode root = root1 as BeTreeNode;
            if (node == null || root == null || node == root)
            {
                return;
            }
            switch (_isChildDrag)
            {
                case NodeDragType.CtrlDrag:
                    NodeSetToChild?.Invoke(root, node);
                    break;
                case NodeDragType.ShiftDrag:
                    NodeInsert?.Invoke(root, node);
                    break;
            }
            _isChildDrag = NodeDragType.None;
            _dragingNode = null;
            ReCalculateNode();
            e.Use();
        }

        public void StartDrag(EditorControl ec, EditorEvent e)
        {
            if (e.Event.button != 0)
            {
                return;
            }
            if (e.Event.control)
            {
                _mouseOffset = e.Event.mousePosition - NodePanels.LocalPosition - ec.LocalPosition;
                EditorControlDragEventManager.Instance.StartDragEvent(ec);
                e.Use();
                _isChildDrag = NodeDragType.CtrlDrag;
                _dragingNode = ec;
            }
            else if (e.Event.shift)
            {
                _mouseOffset = e.Event.mousePosition - NodePanels.LocalPosition - ec.LocalPosition;
                EditorControlDragEventManager.Instance.StartDragEvent(ec);
                _isChildDrag = NodeDragType.ShiftDrag;
                _dragingNode = ec;
                e.Use();
            }
        }
        #endregion

        public void RefreshNodeParam(params NodeParam[] roots)
        {
            DetialPanel.Hide();
            NodeSelectedPanel.Active = false;
            foreach (NodeParam root in roots)
            {
                Dictionary<int, BeTreeNode> id2Node;
                if (!_srcNode.TryGetValue(root.SrcTreeID, out id2Node))
                {
                    id2Node = new Dictionary<int, BeTreeNode>();
                    _srcNode.Add(root.SrcTreeID, id2Node);
                }
                BeTreeNode node = NodeParamCreatorHelper.CreateTree(root, this, id2Node);
                NodeList[node.SrcTreeID] = node;
            }

            ReCalculateNode();
        }

        public void ShowExPanel(BeTreeNode arg1)
        {
            OnNodeRightClick?.Invoke(arg1, true);
        }

        public void ShowExPanelExchange(BeTreeNode ec)
        {
            OnNodeRightClick?.Invoke(ec, false);
        }

        public void ShowNodeDetial(EditorControl arg1, EditorEvent arg2)
        {
            if (_dragingNode != null)
            {
                return;
            }
            BeTreeNode node = arg1 as BeTreeNode;
            OnNodeClick?.Invoke(node);
            arg2.Use();
        }
        #endregion

        public void ForeachNode(Action<BeTreeNode> act)
        {
            foreach (var trees in _srcNode.Values)
            {
                foreach (BeTreeNode node in trees.Values)
                {
                    act(node);
                }
            }
        }

        #region 重画与显示
        public void ReCalculateNode()
        {
            float height = 0;
            float width = 0;
            foreach (BeTreeNode node in NodeList.Values)
            {
                height += DrawNode(node, height) + NodeScale.y;
                width = Mathf.Max(node.ChildSize.x, width);
            }
            SetLine();
            NodePanels.Size = new Vector2(width, height);
            LinkCanvas.Size = NodePanels.Size;
        }

        private float DrawNode(BeTreeNode node, float scale)
        {
            if (!node.Active)
            {
                return scale;
            }
            float startY = scale;
            float childWidth = 0;

            if (node.ChildrenShow)
            {
                foreach (BeTreeNode child in node.NodeChildren)
                {
                    scale = DrawNode(child, scale) + NodeScale.y;
                    childWidth = Mathf.Max(child.ChildSize.x, childWidth);
                }
            }
            float x = (NodeScale.x + node.Size.x) * node.FloorCount;
            if (node.NodeChildren.Count > 0 && node.ChildrenShow)
            {
                scale -= NodeScale.y;
                float width = scale - startY;
                node.ChildSize = new Vector2(childWidth + node.Size.x + NodeScale.x, width);
                float y = scale - (width + node.Size.y) * 0.5f;
                node.LocalPosition = new Vector2(x, y) + _canvasOffset;
            }
            else
            {
                node.ChildSize = node.Size;
                float y = scale;
                node.LocalPosition = new Vector2(x, y) + _canvasOffset;
                scale += node.Size.y;
            }
            return scale;
        }

        private void SetLine()
        {
            List<Vector2> linePoints = new List<Vector2>();
            foreach (BeTreeNode root in NodeList.Values)
            {
                Queue<BeTreeNode> queue = new Queue<BeTreeNode>();
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    BeTreeNode node = queue.Dequeue();
                    if (!node.ChildrenShow)
                    {
                        continue;
                    }
                    Vector2 startP = node.LocalPosition + new Vector2(node.Size.x - 40, node.Size.y / 2);
                    foreach (BeTreeNode child in node.NodeChildren)
                    {
                        Vector2 endPoint = child.LocalPosition + new Vector2(40, node.Size.y / 2);
                        linePoints.Add(startP);
                        linePoints.Add(endPoint);
                        queue.Enqueue(child);
                    }
                }
            }

            LinkCanvas.DrawLine(linePoints.ToArray());
        }
        #endregion

        public void ShowDetialPanel(NodeParam param, NodeParamIOData infos)
        {
            BeTreeNode node = _srcNode[param.SrcTreeID][param.NodeID];
            if (!NodeSelectedPanel.Active && !SelectedNode(GetBtnFromParam(param)))
            {
                DetialPanel.Hide();
                return;
            }
            Vector2 pos = node.LocalPosition + NodePanels.LocalPosition + new Vector2(node.Size.x, 0);
            DetialPanel.LocalPosition = pos;
            DetialBackground.LocalPosition = pos;
            NodeSelectedPanel.Active = false;
            DetialPanel.Show(param, infos);
        }

        private void MouseClick(EditorControl arg1, EditorEvent arg2)
        {
            DetialPanel.Hide();
            NodeSelectedPanel.Active = false;
        }

        public void ShowAddNodePanel(EditorControl e, NodeParam[] ps, bool isAdd)
        {
            BeTreeNode node = e as BeTreeNode;
            if (!DetialPanel.Active && !SelectedNode(node))
            {
                NodeSelectedPanel.Active = false;
                return;
            }
            DetialPanel.Hide();
            NodeSelectedPanel.Init(ps, isAdd);
            NodeSelectedPanel.Active = true;
            NodeSelectedPanel.LocalPosition = node.LocalPosition + NodePanels.LocalPosition + new Vector2(node.Size.x, 0);
        }

        public BeTreeNode GetBtnFromParam(NodeParam param)
        {
            return _srcNode[param.SrcTreeID][param.NodeID];
        }

        #region 选中处理
        private List<BeTreeNode> _outputList = new List<BeTreeNode>();
        private BeTreeNode _curSelected;

        private bool SelectedNode(BeTreeNode node)
        {
            if (node == _curSelected)
            {
                return true;
            }
            _curSelected?.SetSelected(false);
            ClearOutputShow();
            if (node == null)
            {
                DetialPanel.Hide();
                NodeSelectedPanel.Active = false;
                _curSelected = null;
                return false;
            }
            
            _curSelected = node;
            node.SetSelected(true);
            SetOutputShow();
            return true;
        }

        private void ClearOutputShow()
        {
            foreach (BeTreeNode btn in _outputList)
            {
                btn.SetOutput(false);
            }
            _outputList.Clear();
        }

        private BeTreeNode CurSelectedNode => _curSelected;


        public void SetOutputShow()
        {
            foreach (ParamInfoInput input in _curSelected.ParamData.Inputs)
            {
                if (input.Input != null)
                {
                    BeTreeNode nodeBtn = GetBtnFromParam(input.Input.SrcParam);
                    nodeBtn.SetOutput(true);
                    _outputList.Add(nodeBtn);
                }

            }
        }

        public void PointToNode(int flag, int id)
        {
            Vector2 src = NodePanels.LocalPosition;

            BeTreeNode node = _srcNode[flag][id];
            Vector2 targetPos = node.Size / 2;
            Vector2 pos = -node.LocalPosition - targetPos + Size / 2;

            pos.x = Mathf.RoundToInt(pos.x);
            pos.y = Mathf.RoundToInt(pos.y);

            Vector2 delta = pos - src;
            NodePanels.LocalPosition += delta;
            DetialPanel.LocalPosition += delta;
            DetialBackground.LocalPosition += delta;
            NodeSelectedPanel.LocalPosition += delta;
        }
        #endregion
    }
}

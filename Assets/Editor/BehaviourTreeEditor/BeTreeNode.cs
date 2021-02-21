using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Model
{
    public class BeTreeNode : EditorControl
    {
        public EditorImage BgImg;
        public EditorText NodeIDText;
        public EditorText TypeName;
        public EditorText TypeDesc;
        public EditorButton ShowCloseFlag;

        public int NodeID { get; set; }

        public List<BeTreeNode> NodeChildren = new List<BeTreeNode>();

        public Texture2D NoneLeaf;
        public Texture2D RootNode;
        public Texture2D LeafNode;

        private bool _isError;
        private bool _isSelected;
        private bool _isOutput;

        public EditorImage NodeSelected;
        public EditorImage NodeError;
        public EditorImage NodeOutput;
        public EditorImage NodeDebug;

        public BeTreeNode NodeParent { get; private set; }
        public int FloorCount { get; private set; } = 0;
        public int SrcTreeID;

        public Vector2 ChildSize;
        public Action OnChildrenShowStateChange;

        public bool IsError => _isError;
        private NodeParam _param;
        private bool _isDebug;

        public NodeParam ParamData => _param;
        public bool ChildrenShow;

        public override void InitFinish()
        {
            TypeName.Color = Color.white;
            TypeDesc.Color = Color.white;
            NodeIDText.Color = Color.white;

            //TypeName.Font = EditorTreeConfigHelper.Instance.Config.NodeForm;
            TypeName.FontSize = EditorTreeConfigHelper.Instance.Config.FontSize;

            //TypeDesc.Font = EditorTreeConfigHelper.Instance.Config.NodeForm;
            TypeDesc.FontSize = EditorTreeConfigHelper.Instance.Config.FontSize;

            //NodeIDText.Font = EditorTreeConfigHelper.Instance.Config.NodeForm;
            NodeIDText.FontSize = EditorTreeConfigHelper.Instance.Config.FontSize;

            ShowCloseFlag.ContentColor = Color.white;
            ShowCloseFlag.TextFontStyle = FontStyle.Bold;
            ShowCloseFlag.ContentOffset = new Vector2(0, -3);

            LeafNode = BgImg.Bg;
            NoneLeaf = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Editor/Resources/NoneLeaf.png");
            RootNode = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Editor/Resources/RootNode.png");

            ShowCloseFlag.OnBtnClick = ChildrenShowTypeChange;

            OnActiveChange.Add((ee) =>
            {
                if (_param != null)
                {
                    _param.IsShow = Active;
                }
            });
        }

        private void ChildrenShowTypeChange(EditorControl ec)
        {
            ChildrenShow = !ChildrenShow;
            Queue<BeTreeNode> childrenQueue = new Queue<BeTreeNode>();
            foreach (BeTreeNode child in NodeChildren)
            {
                childrenQueue.Enqueue(child);
            }

            while (childrenQueue.Count > 0)
            {
                BeTreeNode node = childrenQueue.Dequeue();
                node.Active = ChildrenShow;
                foreach (BeTreeNode child in node.NodeChildren)
                {
                    childrenQueue.Enqueue(child);
                }
            }
            OnChildrenShowStateChange?.Invoke();
            if (_param != null)
            {
                _param.IsShowChild = ChildrenShow;
            }
        }

        public BeTreeNode()
        {
            OnMouseDown.Add((k, e) =>
            {
                e.Use();
            });
        }

        public void AddChild(BeTreeNode node, IEditorControl parent)
        {
            NodeChildren.Add(node);
            node.NodeParent = this;
            node.FloorCount = FloorCount + 1;
            node.SetParent(parent);
        }

        public void RemoveChild(BeTreeNode node)
        {
            NodeChildren.Remove(node);
            FloorCount = 0;
            NodeParent = null;
            node.SetParent(null);
        }

        public void NodeTypeSet(NodeParam param)
        {
            _param = param;

            if (EditorTreeConfigHelper.Instance.Config.ShowTreeID)
            {
                NodeIDText.Content = $"{param.NodeID}({param.SrcTreeID})";
            }
            else
            {
                NodeIDText.Content = $"{param.NodeID}";
            }
            TypeName.Content = param.NodeType.Name;
            TypeDesc.Content = param.NodeDesc;

            switch (param.NodeClassType)
            {
                case NodeClassifyType.Action:
                case NodeClassifyType.Condition:
                case NodeClassifyType.DataTransform:
                    ShowCloseFlag.Active = false;
                    BgImg.Bg = LeafNode;
                    break;
                case NodeClassifyType.Composite:
                case NodeClassifyType.Decorator:
                    ShowCloseFlag.Active = true;
                    BgImg.Bg = NoneLeaf;
                    break;
                case NodeClassifyType.Root:
                    ShowCloseFlag.Active = true;
                    BgImg.Bg = RootNode;
                    break;
            }

            ErrorCheck();
        }

        private void ErrorCheck()
        {
            bool isError = false;
            foreach (var input in _param.Inputs)
            {
                if (input.Input == null)
                {
                    isError = true;
                    break;
                }
            }

            SetError(isError);
        }

        public override void Dispose()
        {
            NodeParent = null;
            NodeChildren.Clear();
            base.Dispose();
        }

        public void ShowChild(bool type)
        {
            foreach (BeTreeNode child in NodeChildren)
            {
                child.Active = type;
            }
        }

        #region 处理外描边方法
        public void SetError(bool state)
        {
            _isError = state;
            UpdateOutlineType();
        }

        public void SetSelected(bool state)
        {
            _isSelected = state;
            UpdateOutlineType();
        }

        public void SetOutput(bool state)
        {
            _isOutput = state;
            UpdateOutlineType();
        }

        public void SetDebug(bool state)
        {
            _isDebug = state;
            UpdateOutlineType();
        }

        private void UpdateOutlineType()
        {
            if (_isError)
            {
                NodeError.Active = true;
                NodeSelected.Active = false;
                NodeOutput.Active = false;
                NodeDebug.Active = false;
            }
            else if (_isDebug)
            {
                NodeDebug.Active = true;
                NodeError.Active = false;
                NodeOutput.Active = false;
                NodeSelected.Active = false;
            }
            else if(_isSelected)
            {
                NodeError.Active = false;
                NodeSelected.Active = true; 
                NodeOutput.Active = false;
                NodeDebug.Active = false;
            }
            else if(_isOutput)
            {
                NodeError.Active = false;
                NodeSelected.Active = false;
                NodeOutput.Active = true;
                NodeDebug.Active = false;
            }
            else
            {
                NodeDebug.Active = false;
                NodeError.Active = false;
                NodeSelected.Active = false;
                NodeOutput.Active = false;
            }
        }
        #endregion
    }
}

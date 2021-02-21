using System;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public class NodeFilterPanel : EditorControl
    {
        public EditorText FilterField;
        public EditorPanel DataButton;
        
        private string _filterText;
        private List<EditorButton> _selectionButtons = new List<EditorButton>();

        private NodeParam[] _baseStr;
        private NodeParam[] _showStr;

        public Action<Type> OnAddSelected;
        public Action<Type> OnChangeSelected;
        private bool _isAdd;

        public override void InitFinish()
        {
            base.InitFinish();
            FilterField.OnContentChange = () => { OnContentChange(); };
            OnMouseClick.Add((c, e) => e.Use());

            FilterField.Editable = true;
            FilterField.Content = "";
            FilterField.Color = Color.gray;
            FilterField.TextFontStyle = FontStyle.BoldAndItalic;
        }

        private EditorButton CreateButton(int index)
        {
            EditorButton button = NodeFactoryXML.CreateEditorControl<EditorButton>();
            button.Size = new Vector2(275, 30);
            button.SetParent(DataButton);
            button.LocalPosition = new Vector2(5, 30 * index);
            button.OnBtnClick = (e) =>
            {
                Type type = (button.Content as NodeParam).NodeType;
                if (_isAdd)
                {
                    OnAddSelected?.Invoke(type);
                }
                else
                {
                    OnChangeSelected?.Invoke(type);
                }
                Active = false;
            };
            return button;
        }

        public void Init(NodeParam[] pas, bool isAdd)
        {
            FilterField.SetFocus();
            FilterField.Content = "";
            _baseStr = pas;
            _isAdd = isAdd;
            OnContentChange();
        }

        public void OnContentChange()
        {
            _filterText = FilterField.Content.ToString();
            _showStr = Filt();
            Show();
        }

        private void Show()
        {
            while (_selectionButtons.Count < _showStr.Length)
            {
                _selectionButtons.Add(CreateButton(_selectionButtons.Count));
            }
            
            for (int i = 0; i < _selectionButtons.Count; ++i)
            {
                EditorButton button = _selectionButtons[i];
                if (_showStr.Length <= i)
                {
                    button.Active = false;
                    continue;
                }
                button.Active = true;
                NodeParam str = _showStr[i];
                button.Content = str;
            }
        }

        private NodeParam[] Filt()
        {
            if (string.IsNullOrEmpty(_filterText))
            {
                return _baseStr;
            }
            List<NodeParam> strs = new List<NodeParam>();
            foreach (NodeParam str in _baseStr)
            {
                if (str.NodeType.Name.ToLower().Contains(_filterText.ToLower()))
                {
                    strs.Add(str);
                }
            }
            return strs.ToArray();
        }
    }
}

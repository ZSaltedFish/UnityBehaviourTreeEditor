﻿using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Model
{
    public class EditorPopupMenu : EditorControl
    {
        public int Count { get { return _objCallBack.Count; } }
        private Dictionary<object, Action<object>> _objCallBack = new Dictionary<object, Action<object>>();
        private Dictionary<object, EditorButton> _buttons = new Dictionary<object, EditorButton>();

        public static Vector2 BTN_SIZE = new Vector2(160, 30);

        public EditorPopupMenu()
        {
            Style = EditorStyles.textArea;
        }

        public void AddMenu(object data, Action<object> callBack)
        {
            _objCallBack.Add(data, callBack);
            EditorButton btn = NodeFactoryXML.CreateEditorControl<EditorButton>();
             btn.OnBtnClick = (curBtn) => { SetParent(null); _objCallBack[curBtn.Content](curBtn.Content); };
            btn.SetParent(this);
            btn.Size = BTN_SIZE;
            btn.Content = data;
            btn.LocalPosition = new Vector2(0, BTN_SIZE.y * _buttons.Count);

            btn.Style = "Button";
            btn.DefaultStyle = true;

            _buttons.Add(data, btn);
            ReCalu();
        }

        public void Remove(object data)
        {
            _objCallBack.Remove(data);
            EditorButton btn = _buttons[data];
            _buttons.Remove(data);
            btn.Dispose();

            int index = 0;
            foreach (EditorButton b in _buttons.Values)
            {
                b.LocalPosition = new Vector2(0, BTN_SIZE.y * index++);
            }
            ReCalu();
        }

        private void ReCalu()
        {
            Size = new Vector2(BTN_SIZE.x, BTN_SIZE.y * _buttons.Count);
        }
    }
}

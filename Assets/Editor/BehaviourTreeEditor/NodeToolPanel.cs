using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Model
{
    public class NodeToolPanel : EditorControl
    {
        private List<BeTreeNode> _seachBtn = new List<BeTreeNode>();
        private string _seachKey;
        public Action<string> OnSearch;
        public Action<BeTreeNode> LocationNode;

        public override void InitFinish()
        {
            base.InitFinish();
            Style = "Box";
        }

        protected override void Draw()
        {
            base.Draw();
            using (new EditorVerticalLayout("Box"))
            {
                EditorGUILayout.LabelField("Sreach：ID、Name、Description");
                _seachKey = EditorGUILayout.TextField(_seachKey, GUILayout.Height(50));
            }
            if (GUILayout.Button("Search"))
            {
                if (!string.IsNullOrEmpty(_seachKey))
                {
                    OnSearch?.Invoke(_seachKey);
                }
            }

            using (new EditorVerticalLayout("Button"))
            {
                foreach (BeTreeNode btn in _seachBtn)
                {
                    if (GUILayout.Button(btn.TypeName.Content.ToString()))
                    {
                        LocationNode?.Invoke(btn);
                    }
                }
            }
        }

        public void ShowData(List<BeTreeNode> bList)
        {
            _seachBtn = bList;
        }
    }
}

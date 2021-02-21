using System;
using UnityEditor;
using UnityEngine;

namespace Model
{
    public class NodeDebugPanel : EditorControl
    {
        public EditorPanel ScrollPanel;
        public EditorList AutoList;

        public Action<int, int, NodeDebugPanel> FrameSelected;
        public Action OnClearClick;
        private bool _isStop = false;
        public bool IsStop
        {
            get { return _isStop; }
            set { _isStop = value; }
        }
        
        public NodeDebugPanel()
        {
            IsStop = !EditorTreeConfigHelper.Instance.Config.DebugEnable;
        }

        public void AddItem(int treeFlag)
        {
            EditorButton btn = NodeFactoryXML.CreateEditorControl<EditorButton>();
            btn.DefaultStyle = true;
            btn.Style = EditorStyles.miniButton;
            btn.Size = new Vector2(Size.x, 30);
            int index = AutoList.Count;
            btn.Content = $"{index}";
            AutoList.AddItem(btn);
            btn.OnBtnClick = b => { FrameSelected?.Invoke(treeFlag, int.Parse(b.Content.ToString()), this); };
        }

        public void Clear()
        {
            AutoList.Clear();
        }

        public void TryClear()
        {
            OnClearClick?.Invoke();
        }

        public override void InitFinish()
        {
            base.InitFinish();
            ScrollPanel.Style = EditorStyles.textField;
            Active = Application.isPlaying;

            EditorPopupMenu menu = new EditorPopupMenu();
            menu.AddMenu("Pause", obj => _isStop = true);
            menu.AddMenu("Resume", obj => _isStop = false);
            menu.AddMenu("Clear", obj => OnClearClick?.Invoke());
            Context = menu;
        }
    }
}

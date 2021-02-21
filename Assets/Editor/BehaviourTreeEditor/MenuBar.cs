using System.Collections.Generic;
using UnityEditor;

namespace Model
{
    public class MenuBar : EditorControl
    {
        private Dictionary<object, EditorPopupMenu> _btns = new Dictionary<object, EditorPopupMenu>();

        public MenuBar()
        {
            Style = EditorStyles.toolbar;
        }

        public override void InitFinish()
        {
            base.InitFinish();
            EditorPopupMenu filePop = NodeFactoryXML.CreateEditorControl<EditorPopupMenu>();
        }
    }
}

using UnityEngine;

namespace Model
{
    public interface IEditorSeletable
    {
        void Click(EditorEvent e);
        void RightClick(EditorEvent e);
        bool PosIsOn(Vector2 mouse);
        void DragOut(IEditorSeletable ctrl, EditorEvent e);
        void DragIn(IEditorSeletable ctrl, EditorEvent e);
        void DragStart(EditorEvent e);
        void MouseIn(EditorEvent e);
        void MouseOut(EditorEvent e);
        void MouseUp(EditorEvent e);
        void MouseDown(EditorEvent e);
        void KeyDown(EditorEvent e);
    }
}

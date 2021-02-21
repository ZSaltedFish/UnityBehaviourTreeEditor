using System;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public class EditorControlDragEventManager
    {
        private static EditorControlDragEventManager _instance;
        public static EditorControlDragEventManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EditorControlDragEventManager();
                }
                return _instance;
            }
        }
        private IEditorSeletable _dragOutCtrl;
        public void StartDragEvent(EditorControl ec)
        {
            _dragOutCtrl = ec;
        }

        private List<IEditorSeletable> _lastFrameList = new List<IEditorSeletable>();
        private List<IEditorSeletable> _mouseDownList = new List<IEditorSeletable>();
        private EditorPopupMenu _curPopup;

        public void FilterCtrl(List<IEditorSeletable> list, Event e)
        {
            RunEvent(_lastFrameList, e, (ies, ee) =>
            {
                if (!list.Contains(ies))
                {
                    ies.MouseOut(ee);
                }
            });


            RunEvent(list, e, (ies, ee) =>
            {
                if (!_lastFrameList.Contains(ies))
                {
                    ies.MouseIn(ee);
                }
            });

            if (e.isMouse)
            {
                if (_curPopup != null && !list.Contains(_curPopup))
                {
                    _curPopup.SetParent(null);
                    _curPopup = null;
                }
            }

            switch (e.type)
            {
                case EventType.MouseDown:
                    RunEvent(list, e, (ies, ee) => ies.MouseDown(ee));
                    _mouseDownList = list;
                    break;
                case EventType.MouseUp:
                    RunEvent(list, e, (ies, ee) => ies.MouseUp(ee));
                    RunEvent(list, e, (ies, ee) =>
                    {
                        if (_mouseDownList.Contains(ies))
                        {
                            if (e.button == 0)
                            {
                                ies.Click(ee);
                            }
                            else if(e.button == 1)
                            {
                                ies.RightClick(ee);
                                EditorPopupMenu menu = (ies as EditorControl)?.Context;
                                if (menu != null)
                                {
                                    PopupMenu(ies as EditorControl, menu, ee.Event.mousePosition);
                                    ee.Use();
                                }
                            }
                        }
                    });
                    if (_dragOutCtrl != null)
                    {
                        RunEvent(list, e, (ies, ee) =>
                        {
                            _dragOutCtrl.DragOut(ies, ee);
                            ies.DragIn(_dragOutCtrl, ee);
                        });
                        _dragOutCtrl = null;
                    }
                    break;
                case EventType.KeyUp:
                    RunEvent(_mouseDownList, e, (ies, ee) =>
                    {
                        ies.KeyDown(ee);
                    });
                    break;
            }
            _lastFrameList = list;
        }

        public void PopupMenu(EditorControl ctrl, EditorPopupMenu menu, Vector2 pos)
        {
            _curPopup?.SetParent(null);
            _curPopup = menu;
            _curPopup.LocalPosition = pos;
            _curPopup.SetParent(ctrl.Root);
        }

        private void RunEvent(List<IEditorSeletable> selectable, Event e, Action<IEditorSeletable, EditorEvent> act)
        {
            EditorEvent ev = new EditorEvent(e);
            foreach (IEditorSeletable ies in selectable)
            {
                if (ev.IsUsed())
                {
                    return;
                }

                act(ies, ev);
            }
        }
    }
}

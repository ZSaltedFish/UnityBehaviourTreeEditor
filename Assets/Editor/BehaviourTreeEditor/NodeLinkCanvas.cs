using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Model
{
    public class NodeLinkCanvas : EditorControl
    {
        private List<Vector2> _vPoints = new List<Vector2>();

        public void DrawLine(params Vector2[] vs)
        {
            _vPoints = new List<Vector2>(vs);
        }

        protected override void Draw()
        {
            base.Draw();
            if (_vPoints == null)
            {
                return;
            }

            for (int i = 0; i < _vPoints.Count; i += 2)
            {
                Handles.DrawAAPolyLine(_vPoints[i], _vPoints[i + 1]);
            }
        }
    }
}

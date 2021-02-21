using System;
using UnityEditor;
using UnityEngine;

namespace Model
{
    public class BehaviourTreeDebugPanel : EditorControl
    {
        private const float SHOW_TIME = 3;
        private static BehaviourTreeDebugPanel Instance;
        public EditorText DebugInfoText;

        private DateTime _curShowTime;

        public override void InitFinish()
        {
            base.InitFinish();
            Instance = this;
            //DebugInfoText.Style = EditorStyles.textField;
            DebugInfoText.Color = Color.white;
            DebugInfoText.FontSize = 30;
        }

        public override void Dispose()
        {
            Instance = null;
            base.Dispose();
        }

        protected override void Draw()
        {
            base.Draw();
            if (Active)
            {
                if ((DateTime.Now - _curShowTime).TotalSeconds > SHOW_TIME)
                {
                    Active = false;
                }
            }
        }

        public static void Log(TextNewECtrl root, object data)
        {
            root.BTreeDebugPanel.DebugInfoText.Color = Color.white;
            root.BTreeDebugPanel.DebugInfoText.Content = data;
            root.BTreeDebugPanel._curShowTime = DateTime.Now;
            root.BTreeDebugPanel.Active = true;
        }

        public static void Error(TextNewECtrl root, object data)
        {
            Model.Log.Error(data.ToString());
            root.BTreeDebugPanel.DebugInfoText.Color = Color.red;
            root.BTreeDebugPanel.DebugInfoText.Content = data;
            root.BTreeDebugPanel._curShowTime = DateTime.Now;
            root.BTreeDebugPanel.Active = true;

            EditorUtility.DisplayDialog("错误", data.ToString(), "确认");
        }

        public static void Error(object data)
        {
            Model.Log.Error(data.ToString());
            EditorUtility.DisplayDialog("错误", data.ToString(), "关闭");
        }
    }
}

using System.IO;
using UnityEditor;
using UnityEngine;

namespace Model
{
    public class EditorTreeConfigHelper
    {
        public const string DATA_PATH = "Assets/BehaviourTreeConfig.txt";

        private static EditorTreeConfigHelper _instance;

        public static EditorTreeConfigHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EditorTreeConfigHelper();
                }
                return _instance;
            }
        }

        public TextBehaviourTreeConfig Config
        {
            get
            {
                return TreeConfigPanel.LocalConfig;
            }
        }
    }
}

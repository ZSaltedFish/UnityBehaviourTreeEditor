using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Model
{
    public class TreeConfigPanel : EditorWindow
    {
        public const string DATA_PATH = "Assets/Editor/Resources/TreeConfig/TreeConfig.txt";
        private bool _isFix = false;
        private Dictionary<FieldInfo, string> _info2Name = new Dictionary<FieldInfo, string>();
        private Vector2 _v;
        private static TextBehaviourTreeConfig _config;
        public static TextBehaviourTreeConfig LocalConfig
        {
            get
            {
                ReadData();
                return _config;
            }
        }

        private static void ReadData()
        {
            if (_config != null)
            {
                return;
            }
            try
            {
                using (StreamReader reader = new StreamReader(DATA_PATH))
                {
                    _config = MongoHelper.FromJson<TextBehaviourTreeConfig>(reader.ReadToEnd());
                }
            }
            catch (Exception err)
            {
                Log.Warning($"读取行为树配置数据失败，重新创建{err}");
                _config = new TextBehaviourTreeConfig();
            }
        }

        public void Awake()
        {
            Type config = typeof(TextBehaviourTreeConfig);
            foreach (FieldInfo field in config.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
            {
                TreeConfigAttribute attr = field.GetCustomAttribute<TreeConfigAttribute>();
                if (attr != null)
                {
                    _info2Name.Add(field, attr.Desc);
                }
            }

            ReadData();
        }

        public void OnGUI()
        {
            _v = EditorGUILayout.BeginScrollView(_v);
            foreach (var pair in _info2Name)
            {
                object oldValue = pair.Key.GetValue(_config);
                object value = EditorDataFields.EditorDataField(pair.Value, oldValue, pair.Key.FieldType);
                if (!oldValue.Equals(value))
                {
                    _isFix = true;
                }
                pair.Key.SetValue(_config, value);
            }
            EditorGUILayout.EndScrollView();
        }

        public void OnDestroy()
        {
            if (_isFix)
            {
                using (FileStream file = new FileStream(DATA_PATH, FileMode.Create))
                {
                    StreamWriter writer = new StreamWriter(file);
                    writer.Write(MongoHelper.ToJson(_config));
                    writer.Close();
                }
            }
        }
    }
}

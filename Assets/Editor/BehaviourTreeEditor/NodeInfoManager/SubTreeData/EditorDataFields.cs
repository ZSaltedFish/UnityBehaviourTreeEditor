using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Model
{
    public partial class EditorDataFields
    {
        [EditorDataField(typeof(ServerSubTree), false)]
        private static object ServerSubTree(string desc, object data, Type type)
        {
            if (data == null)
            {
                data = string.Empty;
            }
            string path = data as string;
            using (new EditorHorizontalLayout())
            {
                EditorGUILayout.LabelField(path);
                if (GUILayout.Button("Select"))
                {
                    string str = EditorUtility.OpenFilePanelWithFilters("服务器子树", EditorTreeConfigHelper.Instance.Config.ServersPath, new string[] { "Json File", "txt" });
                    if (!string.IsNullOrEmpty(str))
                    {
                        path = str;
                        path = Path.GetFileName(path).Replace(".txt", "");
                    }
                }

                if (GUILayout.Button("Open"))
                {
                    string newPath = Path.Combine(EditorTreeConfigHelper.Instance.Config.ServersPath, $"{path}.txt");
                    RunTimeNodesManager.ShowGo(newPath);
                }
            }
            return path;
        }
    }
}

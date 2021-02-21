using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Model
{
    public class NodeReplacePanel : EditorWindow
    {
        private string _oldType;
        private string _newType;

        public void OnGUI()
        {
            _oldType = EditorDataFields.EditorDataField("旧的类型", _oldType);
            _newType = EditorDataFields.EditorDataField("新的类型", _newType);

            if (string.IsNullOrEmpty(_oldType) || string.IsNullOrEmpty(_newType))
            {
                return;
            }

            using (new EditorHorizontalLayout("Box"))
            {
                if (GUILayout.Button("替换客户端"))
                {
                    EditorUtility.DisplayDialog("错误", "功能未实现", "关闭");
                }

                if (GUILayout.Button("替换服务器"))
                {
                    if (!EditorUtility.DisplayDialog("警告", "修改后不能够回退，是否确认修改", "OK", "CANCEL"))
                    {
                        return;
                    }
                    string path = EditorTreeConfigHelper.Instance.Config.ServersPath;
                    string[] files = Directory.GetFiles(path, "*.txt");

                    foreach (string file in files)
                    {
                        try
                        {
                            StreamReader reader = new StreamReader(file);
                            string data = reader.ReadToEnd();
                            NodeProto p = MongoHelper.FromJson<NodeProto>(data);
                            p = TypeReplace(_oldType, _newType, p);
                            reader.Close();
                            StreamWriter writer = new StreamWriter(file);
                            writer.Write(MongoHelper.ToJson(p));
                            writer.Close();
                        }
                        catch (Exception err)
                        {
                            BehaviourTreeDebugPanel.Error($"文件({file})无法解析成行为树");
                            Log.Error(err);
                        }
                    }

                    EditorUtility.DisplayDialog("信息", "替换完成", "OK");
                }
            }
        }

        public NodeProto TypeReplace(string oldType, string newType, NodeProto proto)
        {
            Queue<NodeProto> queue = new Queue<NodeProto>();
            queue.Enqueue(proto);

            while (queue.Count > 0)
            {
                NodeProto node = queue.Dequeue();
                if (node.Name == oldType)
                {
                    node.Name = newType;
                }

                foreach (NodeProto child in node.Children)
                {
                    queue.Enqueue(child);
                }
            }
            return proto;
        }
    }
}

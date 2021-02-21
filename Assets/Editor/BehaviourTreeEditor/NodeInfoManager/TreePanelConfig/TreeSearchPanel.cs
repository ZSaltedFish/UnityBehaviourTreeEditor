using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Model
{
    public class TreeSearchPanel : EditorWindow
    {
        private List<NodeParam> _nodes;
        private List<UnityEngine.Object> _goes = new List<UnityEngine.Object>();
        private List<string> _files = new List<string>();
        private NodeParam _selected;
        private string _name;
        public void Awake()
        {
            _nodes = NodeInfoManager.GetAllParam(true);
            _nodes.AddRange(NodeInfoManager.GetAllParam(false));
        }

        public void OnGUI()
        {
            _name = EditorDataFields.EditorDataField("名字", _name);

            using (new EditorHorizontalLayout())
            {
                if (GUILayout.Button("搜索客户端"))
                {
                    bool get = false;
                    _goes.Clear();
                    _files.Clear();
                    foreach (NodeParam param in _nodes)
                    {
                        if (param.NodeType.Name == _name)
                        {
                            get = true;
                            _selected = param;
                            break;
                        }
                    }

                    if (get)
                    {
                        List<string> paths = EditorResHelper.GetAllPath("Assets", true);
                        foreach (string path in paths)
                        {
                            GameObject go = AssetDatabase.LoadAssetAtPath<GameObject>(path);
                            BehaviorTreeConfig config = go.GetComponent<BehaviorTreeConfig>();
                            if (!config)
                            {
                                continue;
                            }

                            NodeProto p = config.RootNodeProto;
                            Stack<NodeProto> stack = new Stack<NodeProto>();
                            stack.Push(p);

                            while (stack.Count > 0)
                            {
                                NodeProto node = stack.Pop();
                                if (node.Name == _name)
                                {
                                    _goes.Add(go);
                                    break;
                                }

                                foreach (NodeProto child in node.Children)
                                {
                                    stack.Push(child);
                                }
                            }
                        }
                    }
                    else
                    {
                        _selected = null;
                    }
                }
                if (GUILayout.Button("搜索服务器"))
                {
                    string path = EditorTreeConfigHelper.Instance.Config.ServersPath;
                    bool get = false;
                    _goes.Clear();
                    _files.Clear();
                    foreach (NodeParam param in _nodes)
                    {
                        if (param.NodeType.Name == _name)
                        {
                            get = true;
                            _selected = param;
                            break;
                        }
                    }

                    if (get)
                    {
                        string[] files = Directory.GetFiles(path, "*.txt");
                        foreach (string file in files)
                        {
                            try
                            {
                                StreamReader reader = new StreamReader(file);
                                string data = reader.ReadToEnd();
                                NodeProto p = MongoHelper.FromJson<NodeProto>(data);
                                Queue<NodeProto> queue = new Queue<NodeProto>();
                                queue.Enqueue(p);
                                while (queue.Count > 0)
                                {
                                    NodeProto node = queue.Dequeue();
                                    if (node.Name == _name)
                                    {
                                        _files.Add(file);
                                        break;
                                    }

                                    foreach (NodeProto child in node.Children)
                                    {
                                        queue.Enqueue(child);
                                    }
                                }
                            }
                            catch(Exception err)
                            {
                                BehaviourTreeDebugPanel.Error($"文件({file})无法解析成行为树");
                                Log.Error(err);
                            }
                        }
                    }
                }
            }

            if (_selected == null)
            {
                EditorGUILayout.LabelField("请输入节点名称，不需要命名空间");
                return;
            }
            if (_goes.Count > 0)
            {
                EditorDataFields.EditorListDataField(_goes, 20);
            }
            else if(_files.Count > 0)
            {
                EditorDataFields.EditorListDataField(_files, 20);
            }
        }
    }
}

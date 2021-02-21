using System;
using System.Collections.Generic;
using System.Reflection;

namespace Model
{
    public class NodeInfoManager
    {
        private static Dictionary<Type, NodeParam> _clientNodes = new Dictionary<Type, NodeParam>();
        private static Dictionary<Type, NodeParam> _serverNodes = new Dictionary<Type, NodeParam>();
        private static NodeParam _errorNode;
        #region 初始化
        /// <summary>
        /// 初始化服务器节点
        /// </summary>
        public static void InitServer()
        {
            Type[] types = typeof(NodeInfoManager).Assembly.GetTypes();
            foreach (Type type in types)
            {
                object[] objs = type.GetCustomAttributes(typeof(NodeAttribute), false);
                foreach (NodeAttribute attr in objs)
                {
                    if (attr.ClassifytType == NodeClassifyType.Error)
                    {
                        continue;
                    }
                    NodeParam p = new NodeParam()
                    {
                        NodeType = type,
                        TypeDesc = attr.Desc,
                        NodeClassType = attr.ClassifytType
                    };

                    FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
                    foreach (FieldInfo field in fields)
                    {
                        NodeFieldAttribute fieldAttr = field.GetCustomAttribute<NodeFieldAttribute>();
                        if (fieldAttr != null)
                        {
                            Type envKeyType = fieldAttr.envKeyType ?? field.FieldType;
                            ParamInfo pInfo = new ParamInfo(field.Name, fieldAttr.Desc, envKeyType, fieldAttr.DefaultValue);
                            p.Fields.Add(pInfo);
                            continue;
                        }

                        NodeInputAttribute inputAttr = field.GetCustomAttribute<NodeInputAttribute>();
                        if (inputAttr != null)
                        {
                            ParamInfoInput pInput = new ParamInfoInput()
                            {
                                InputFieldName = field.Name,
                                Desc = inputAttr.Desc,
                                InputType = inputAttr.envKeyType,
                                SrcInputStr = inputAttr.DefaultValue as string
                            };
                            p.Inputs.Add(pInput);
                            continue;
                        }

                        NodeOutputAttribute outputAttr = field.GetCustomAttribute<NodeOutputAttribute>();
                        if (outputAttr != null)
                        {
                            ParamInfoOutput pInfo = new ParamInfoOutput()
                            {
                                OutputFieldName = field.Name,
                                Desc = outputAttr.Desc,
                                OutputType = outputAttr.envKeyType,
                                OutputName = outputAttr.DefaultValue as string
                            };
                            p.Outputs.Add(pInfo);
                        }
                    }

                    _serverNodes.Add(type, p);
                }
            }
        }

        /// <summary>
        /// 初始化客户端节点
        /// </summary>
        public static void InitClient()
        {
            Type[] types = typeof(Node).Assembly.GetTypes();
            foreach (Type type in types)
            {
                object[] objs = type.GetCustomAttributes(typeof(NodeAttribute), false);
                foreach (NodeAttribute attr in objs)
                {
                    NodeParam p = new NodeParam()
                    {
                        NodeType = type,
                        TypeDesc = attr.Desc,
                        NodeClassType = attr.ClassifytType
                    };

                    FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
                    foreach (FieldInfo field in fields)
                    {
                        NodeFieldAttribute fieldAttr = field.GetCustomAttribute<NodeFieldAttribute>();
                        if (fieldAttr != null)
                        {
                            Type envKeyType = fieldAttr.envKeyType == null ? field.FieldType : fieldAttr.envKeyType;
                            ParamInfo pInfo = new ParamInfo(field.Name, fieldAttr.Desc, envKeyType, fieldAttr.DefaultValue);
                            p.Fields.Add(pInfo);
                            continue;
                        }

                        NodeInputAttribute inputAttr = field.GetCustomAttribute<NodeInputAttribute>();
                        if (inputAttr != null)
                        {
                            ParamInfoInput pInput = new ParamInfoInput()
                            {
                                InputFieldName = field.Name,
                                Desc = inputAttr.Desc,
                                InputType = inputAttr.envKeyType,
                                SrcInputStr = inputAttr.DefaultValue as string
                            };
                            p.Inputs.Add(pInput);
                            continue;
                        }

                        NodeOutputAttribute outputAttr = field.GetCustomAttribute<NodeOutputAttribute>();
                        if (outputAttr != null)
                        {
                            ParamInfoOutput pInfo = new ParamInfoOutput()
                            {
                                OutputFieldName = field.Name,
                                Desc = outputAttr.Desc,
                                OutputType = outputAttr.envKeyType,
                                OutputName = outputAttr.DefaultValue as string
                            };
                            p.Outputs.Add(pInfo);
                        }
                    }

                    if (attr.ClassifytType == NodeClassifyType.Error)
                    {
                        _errorNode = p;
                    }
                    else
                    {
                        _clientNodes.Add(type, p);
                    }
                }
            }
        }
        #endregion

        public static bool TryGetNodeParam(Type type, int nodeID, int srcTreeID, bool isClient, out NodeParam p)
        {
            if (_clientNodes.Count == 0 || _serverNodes.Count == 0)
            {
                InitClient();
                InitServer();
            }
            if (isClient)
            {
                if (!_clientNodes.TryGetValue(type, out p))
                {
                    p = null;
                    return false;
                }
            }
            else
            {
                if (!_serverNodes.TryGetValue(type, out p))
                {
                    p = null;
                    return false;
                }
            }
            p = NodeParamClone(p, nodeID, srcTreeID);
            return true;
        }

        private static NodeParam NodeParamClone(NodeParam src, int nodeID, int srcTreeID)
        {
            NodeParam p = new NodeParam()
            {
                NodeType = src.NodeType,
                NodeDesc = src.NodeDesc,
                NodeClassType = src.NodeClassType,
                NodeID = nodeID,
                SrcTreeID = srcTreeID
            };

            foreach (var item in src.Fields)
            {
                p.Fields.Add(item.Clone());
            }

            foreach (var item in src.Inputs)
            {
                p.Inputs.Add(item.Clone());
            }

            foreach (var item in src.Outputs)
            {
                p.Outputs.Add(item.Clone(p));
            }

            return p;
        }

        public static NodeParam GetNodeParam(Type nodeType, int nodeID, int srcTreeID, bool isClient)
        {
            NodeParam p = default(NodeParam);
            TryGetNodeParam(nodeType, nodeID, srcTreeID, isClient, out p);
            return p;
        }

        public static NodeParam GetErrorParam(int nodeID, int srcTreeID)
        {
            return NodeParamClone(_errorNode, nodeID, srcTreeID);
        }

        public static List<Type> GetAllType(bool isClient)
        {
            if (_clientNodes.Count == 0 || _serverNodes.Count == 0)
            {
                InitServer();
                InitClient();
            }
            return isClient ? new List<Type>(_clientNodes.Keys) : new List<Type>(_serverNodes.Keys);
        }

        public static List<NodeParam> GetAllParam(bool isClient)
        {
            if (_clientNodes.Count == 0 || _serverNodes.Count == 0)
            {
                InitServer();
                InitClient();
            }
            return isClient ? new List<NodeParam>(_clientNodes.Values) : new List<NodeParam>(_serverNodes.Values);
        }
    }
}

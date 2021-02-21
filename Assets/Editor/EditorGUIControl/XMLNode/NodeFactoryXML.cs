using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using UnityEditor;
using UnityEngine;

namespace Model
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class XMLNodeAttribute : Attribute
    {
        public string NodeType;
        public XMLNodeAttribute(string type)
        {
            NodeType = type;
        }
    }

    public static class NodeFactoryXML
    {
        private static Dictionary<string, IDeserializeXML> _node2Desers = new Dictionary<string, IDeserializeXML>();

        public static void Init()
        {
            _node2Desers.Clear();
            Type[] types = typeof(IDeserializeXML).Assembly.GetTypes();
            foreach (Type type in types)
            {
                object[] attrs = type.GetCustomAttributes(typeof(XMLNodeAttribute), false);
                foreach (XMLNodeAttribute attr in attrs)
                {
                    IDeserializeXML xml = Activator.CreateInstance(type) as IDeserializeXML;
                    _node2Desers[attr.NodeType] = xml;
                }
            }
        }

        public static object DeserializeXML(XmlAttribute node, IEditorControl ctrl)
        {
            if (_node2Desers.Count == 0)
            {
                Init();
            }

            IDeserializeXML xml;
            if (!_node2Desers.TryGetValue(node.Name, out xml))
            {
                Log.Error($"未知的XML定义：{node.Name}");
                return null;
            }
            return xml.Deserialize(node, ctrl);
        }

        public static void InitControl(IEditorControl ctrl)
        {
            Type type = ctrl.GetType();
            string path = $"Assets/Editor/ControlXmls/{type.Name}.xml";
            try
            {
                TextAsset ass = AssetDatabase.LoadAssetAtPath<TextAsset>(path);
                if (ass == null)
                {
                    (ctrl as EditorControl)?.InitFinish();
                    return;
                }

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(ass.text);

                XmlNode root = doc.ChildNodes[0];
                TreeDeserialize(ctrl, root, ctrl);
                AttributeDeserialize(root, ctrl, ctrl);
                (ctrl as EditorControl)?.InitFinish();
            }
            catch (Exception err)
            {
                Log.Error($"解析{type.Name}时候错误, {err}");
            }
        }

        public static void TreeDeserialize(IEditorControl parent, XmlNode parentNode, IEditorControl root)
        {
            foreach (XmlNode node in parentNode)
            {
                try
                {
                    EditorControl subCtrl = Activator.CreateInstance(typeof(IEditorControl).Assembly.GetType(node.Name)) as EditorControl;
                    subCtrl.SetParent(parent);
                    InitControl(subCtrl);
                    AttributeDeserialize(node, subCtrl, root);

                    Type type = root.GetType();
                    if (!string.IsNullOrEmpty(subCtrl.Name))
                    {
                        MemberInfo[] infos = type.GetMember(subCtrl.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                        if (infos.Length > 0)
                        {
                            MemberInfo info = infos[0];
                            switch (info.MemberType)
                            {
                                case MemberTypes.Field:
                                    (info as FieldInfo).SetValue(root, subCtrl);
                                    break;
                                case MemberTypes.Property:
                                    (info as PropertyInfo).SetValue(root, subCtrl);
                                    break;
                            }
                        }

                        TreeDeserialize(subCtrl, node, root);
                    }
                }
                catch(Exception err)
                {
                    throw new Exception($"{node.Name}", err);
                }
            }
        }

        private static void AttributeDeserialize(XmlNode node, IEditorControl ctrl, IEditorControl root)
        {
            Type type = ctrl.GetType();
            MemberInfo[] infos = type.GetMembers(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (MemberInfo info in infos)
            {
                object data;
                XmlAttribute attr = node.Attributes[info.Name];
                if (attr == null)
                {
                    continue;
                }
                switch (info.MemberType)
                {
                    case MemberTypes.Field:
                        data = DeserializeXML(node.Attributes[info.Name], root);
                        (info as FieldInfo).SetValue(ctrl, data);
                        break;
                    case MemberTypes.Property:
                        data = DeserializeXML(node.Attributes[info.Name], root);
                        (info as PropertyInfo).SetValue(ctrl, data);
                        break;
                }
            }
        }

        public static T CreateEditorControl<T>() where T : IEditorControl
        {
            IEditorControl ctrl = Activator.CreateInstance<T>();
            InitControl(ctrl);
            return (T)ctrl;
        }
    }
}

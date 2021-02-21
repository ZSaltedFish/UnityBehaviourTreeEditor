using System;
using UnityEngine;

namespace Model
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class TreeConfigAttribute : Attribute
    {
        public string Desc;

        public TreeConfigAttribute(string desc)
        {
            Desc = desc;
        }
    }

    public class BehaviourTreeConfig : MonoBehaviour
    {
        [TreeConfig("允许显示行为树ID")]
        public bool ShowTreeID = false;
        [TreeConfig("节点字体")]
        public Font NodeForm;
        [TreeConfig("节点字体大小")]
        public int FontSize = 13;
        [TreeConfig("默认开启调试")]
        public bool DebugEnable = true;
        [TreeConfig("服务器路径")]
        public string ServersPath = "BehaviourTreeProtos/";
    }

    public class TextBehaviourTreeConfig
    {
        [TreeConfig("允许显示行为树ID")]
        public bool ShowTreeID = false;
        //[TreeConfig("节点字体")]
        //public Font NodeForm;
        [TreeConfig("节点字体大小")]
        public int FontSize = 13;
        [TreeConfig("默认开启调试")]
        public bool DebugEnable = true;
        [TreeConfig("服务器路径")]
        public string ServersPath = "BehaviourTreeProtos/";
    }
}

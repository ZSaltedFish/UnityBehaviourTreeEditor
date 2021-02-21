using System;
using UnityEngine;

namespace Model
{ 

    public class EditorTreeConfig
    {
        public Font NodeForm
        {
            get { return Font.CreateDynamicFontFromOSFont(NodeTextFont, FontSize); }
            set { NodeTextFont = value.name; }
        }

        [TreeConfig("允许显示行为树ID")]
        public bool ShowTreeID;
        [TreeConfig("节点字体")]
        public string NodeTextFont;
        [TreeConfig("节点字体大小")]
        public int FontSize = 13;
        [TreeConfig("默认开启调试")]
        public bool DefaultDebugValue;
    }
}

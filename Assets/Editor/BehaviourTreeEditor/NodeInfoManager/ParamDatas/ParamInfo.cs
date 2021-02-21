using System;

namespace Model
{
    public class ParamInfo
    {
        /// <summary>
        /// 字段名称
        /// </summary>
        public string FieldName;
        /// <summary>
        /// 描述
        /// </summary>
        public string Desc;
        /// <summary>
        /// 类型
        /// </summary>
        public Type ParamType;
        /// <summary>
        /// 缺省值
        /// </summary>
        public object DefaultValue;

        public ParamInfo(string fieldName, string desc, Type pType, object defaultValue)
        {
            FieldName = fieldName;
            Desc = desc;
            ParamType = pType;
            DefaultValue = defaultValue;
        }

        public ParamInfo Clone()
        {
            return new ParamInfo(FieldName, Desc, ParamType, Clone(DefaultValue));
        }

        private static object Clone(object obj)
        {
            if (obj != null && obj.GetType().IsSubclassOf(typeof(Array)))
            {
                return (obj as Array).Clone();
            }

            return obj;
        }
    }
}

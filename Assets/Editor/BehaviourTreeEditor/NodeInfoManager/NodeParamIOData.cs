using System;
using System.Collections.Generic;

namespace Model
{
    public class NodeParamIOData
    {
        private Dictionary<Type, List<ParamInfoOutput>> _paramsInfo = new Dictionary<Type, List<ParamInfoOutput>>();

        public NodeParamIOData Clone()
        {
            NodeParamIOData data = new NodeParamIOData()
            {
                _paramsInfo = new Dictionary<Type, List<ParamInfoOutput>>()
            };

            foreach (var pair in _paramsInfo)
            {
                List<ParamInfoOutput> list = pair.Value.Clone();
                data._paramsInfo.Add(pair.Key, list);
            }

            return data;
        }

        public List<ParamInfoOutput> this[Type type]
        {
            get
            {
                List<ParamInfoOutput> oupts = new List<ParamInfoOutput>();
                foreach (var pair in _paramsInfo)
                {
                    if (pair.Key == typeof(BeHaviourAnyType) || pair.Key.IsSubclassOf(type) || pair.Key == type)
                    {
                        oupts.AddRange(pair.Value);
                    }
                }
                return oupts;
            }
        }

        public void AddParam(Type type, ParamInfoOutput info)
        {
            if (!_paramsInfo.ContainsKey(type))
            {
                _paramsInfo.Add(type, new List<ParamInfoOutput>());
            }
            List<ParamInfoOutput> list = _paramsInfo[type];
            for (int i = 0; i < list.Count; ++i)
            {
                ParamInfoOutput output = list[i];
                if (output.OutputName == info.OutputName)
                {
                    list[i] = info;
                    return;
                }
            }
            list.Add(info);
        }
    }
}

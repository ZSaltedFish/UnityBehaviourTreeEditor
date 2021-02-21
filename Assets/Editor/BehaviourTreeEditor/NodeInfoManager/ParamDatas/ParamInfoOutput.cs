using System;

namespace Model
{
    public class ParamInfoInput
    {
        public string InputFieldName;
        public string Desc;
        public Type InputType;
        public string SrcInputStr;
        public ParamInfoOutput Input;

        public ParamInfoInput Clone()
        {
            ParamInfoInput p = new ParamInfoInput()
            {
                InputFieldName = InputFieldName,
                Desc = Desc,
                InputType = InputType,
                Input = Input,
                SrcInputStr = SrcInputStr
            };
            return p;
        }
    }

    public class ParamInfoOutput
    {
        public NodeParam SrcParam;
        public string Desc;
        public Type OutputType;
        public string OutputName;
        public string OutputFieldName;

        public ParamInfoOutput Clone(NodeParam newParam)
        {
            ParamInfoOutput p = new ParamInfoOutput()
            {
                OutputFieldName = OutputFieldName,
                Desc = Desc,
                OutputType = OutputType,
                OutputName = OutputName,
            };
            p.SrcParam = newParam;
            return p;
        }
    }
}

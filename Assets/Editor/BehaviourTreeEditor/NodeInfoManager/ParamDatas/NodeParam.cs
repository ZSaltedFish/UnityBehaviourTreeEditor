using System;
using System.Collections.Generic;

namespace Model
{
    public class NodeParam
    {
        public string NodeDesc;
        public string TypeDesc;
        public NodeClassifyType NodeClassType;

        public List<ParamInfo> Fields = new List<ParamInfo>();
        public List<ParamInfoInput> Inputs = new List<ParamInfoInput>();
        public List<ParamInfoOutput> Outputs = new List<ParamInfoOutput>();

        public int NodeID;
        public int SrcTreeID;

        public bool IsShowChild = true;
        public Type NodeType;
        public NodeParam Parent;
        private List<NodeParam> _childList = new List<NodeParam>();
        public List<NodeParam> ChildrenList => _childList;

        public bool IsShow = true;

        public void SetParent(NodeParam root)
        {
            Parent?._childList.Remove(this);
            Parent = root;
            root?._childList.Add(this);
        }

        public void InsertParent(NodeParam root, int index)
        {
            Parent?._childList.Remove(this);
            Parent = root;
            root?._childList.Insert(index, this);
        }

        public void Replace(NodeParam newParam)
        {
            TypeDesc = newParam.TypeDesc;
            NodeType = newParam.NodeType;
            NodeClassType = newParam.NodeClassType;

            Fields.Clear();
            foreach (ParamInfo info in newParam.Fields)
            {
                Fields.Add(info.Clone());
            }

            Inputs.Clear();
            foreach (ParamInfoInput input in newParam.Inputs)
            {
                Inputs.Add(input.Clone());
            }

            Outputs.Clear();
            foreach (ParamInfoOutput output in newParam.Outputs)
            {
                Outputs.Add(output.Clone(this));
            }
        }

        public override string ToString()
        {
            return $"{NodeType.Name}({TypeDesc})";
        }
    }
}

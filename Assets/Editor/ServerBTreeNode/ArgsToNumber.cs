using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "类型转换number")]
    public class ArgsToNumber : Node
    {
        public ArgsToNumber(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("输入值", typeof(System.Object))]
        public string InValue;

        [NodeOutput("转换值", typeof(double))]
        public string Value;
    }
}
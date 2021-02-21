using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "类型转换Unit")]
    public class ArgsToUnit : Node
    {
        public ArgsToUnit(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("输入值", typeof(System.Object))]
        public string InValue;

        [NodeOutput("转换值", typeof(Server.Unit))]
        public string Value;
    }
}
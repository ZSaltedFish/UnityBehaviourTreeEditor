using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "类型转换从Unit")]
    public class ArgsFromUnit : Node
    {
        public ArgsFromUnit(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("输入值", typeof(Server.Unit))]
        public string InValue;

        [NodeOutput("转换值", typeof(System.Object))]
        public string Value;
    }
}
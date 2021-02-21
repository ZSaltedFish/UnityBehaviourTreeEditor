using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "检查操作类型,并获取按键力度")]
    public class GetOperState : Node
    {
        public GetOperState(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("检查操作类型")]
        public eOperType Oper;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Unit;

        [NodeOutput("按键力度", typeof(double))]
        public string Power;
        
    }
}
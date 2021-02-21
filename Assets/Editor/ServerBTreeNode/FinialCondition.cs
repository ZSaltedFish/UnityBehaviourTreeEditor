using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "必杀技使用条件")]
    public class FinialCondition : Node
    {
        public FinialCondition(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;
    }
}
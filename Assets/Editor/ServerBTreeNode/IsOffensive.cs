using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "是否进攻方")]
    public class IsOffensive : Node
    {
        public IsOffensive(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;
    }
}
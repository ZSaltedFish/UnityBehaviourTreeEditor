using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "是否需要协防")]
    public class IsNeedDoubleCover : Node
    {
        public IsNeedDoubleCover(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;
    }
}
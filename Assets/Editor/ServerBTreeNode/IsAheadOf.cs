using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "队友是否在我前面")]  
    public class IsAheadOf : Node
    {
        public IsAheadOf(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("检测球员", typeof(Server.Unit))]
        public string Target;
    }
}
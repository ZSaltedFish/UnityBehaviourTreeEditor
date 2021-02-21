using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "判断是第二防守人")]
    public class IsSecondDefender : Node
    {
        public IsSecondDefender(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;
    }
}
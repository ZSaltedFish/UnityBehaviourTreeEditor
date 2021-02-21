using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "取最靠近自己的友方成员")]
    public class GetClosestFriend : Node
    {
        public GetClosestFriend(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("最近队友", typeof(Server.Unit))]
        public string Other;
    }
}
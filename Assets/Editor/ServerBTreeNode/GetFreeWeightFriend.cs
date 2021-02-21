using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取未被敌方势力影响的队友")]
    public class GetFreeWeightFriend : Node
    {
        public GetFreeWeightFriend(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("队友", typeof(Server.Unit))]
        public string Other;
    }
}
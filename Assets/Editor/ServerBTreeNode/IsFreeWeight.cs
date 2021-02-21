using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "本人是否示未被敌方势力影响")]
    public class IsFreeWeight : Node
    {
        public IsFreeWeight(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;
    }
}
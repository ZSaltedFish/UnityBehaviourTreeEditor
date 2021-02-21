using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "检查球是否在大禁区")]
    public class CheckBallInPenalty : Node
    {
        public CheckBallInPenalty(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("0双方, 1友方, 2敌方")]
        public int SType;

        [NodeInput("对象", typeof(Server.Unit))]
        public string Self;
        
    }
}
using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "计算触发几率")]
    public class GetProbability : Node
    {
        public GetProbability(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("临界值1-100")]
        public int Threshold;

        [NodeInput("Threshold(可选)", typeof(double))]
        public string InThreshold;

      

    }
}
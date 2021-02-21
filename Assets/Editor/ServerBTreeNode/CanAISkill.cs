using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "可以释放技能")]
    public class CanAISkill : Node
    {
        public CanAISkill(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("自己", typeof(Server.Unit))]
        public string Self;

        [NodeInput("目标(球/球员)", typeof(Server.Object))]
        public string Target;

        [NodeInput("球门", typeof(Server.Goal))]
        public string Goal;
    }
}
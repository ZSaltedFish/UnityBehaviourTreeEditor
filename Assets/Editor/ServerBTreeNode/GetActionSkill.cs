using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "获取球员当前技能")]
    public class GetActionSkill : Node
    {
        public GetActionSkill(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("目标技能", typeof(Server.Skill))]
        public string OutSkill;
    }
}
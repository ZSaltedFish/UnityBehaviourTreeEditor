using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "获取基本技能")]
    public class GetBaseSkill : Node
    {
        public GetBaseSkill(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("技能类型")]
        public eSkillBase SkillType;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("技能ID", typeof(int))]
        public string SkillID;
    }
}
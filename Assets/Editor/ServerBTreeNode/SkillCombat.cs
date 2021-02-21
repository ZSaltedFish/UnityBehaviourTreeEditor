using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "技能属性碰撞)")]
    public class SkillCombat : Node
    {
        public SkillCombat(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("攻击技能", typeof(Server.Skill))]
        public string AtkSkill;

        [NodeInput("防守技能ID", typeof(int))]
        public string DefSkillID;

        [NodeInput("攻击者球员", typeof(Server.Unit))]
        public string Owner;

        [NodeInput("被攻击者球员 ", typeof(Server.Unit))]
        public string Other;
    }
}
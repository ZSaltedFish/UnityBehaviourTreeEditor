using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "技能使用条件(必杀)")]
    public class SkillCondition : Node
    {
        public SkillCondition(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("技能", typeof(int))]
        public string SpellID;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;
    }
}
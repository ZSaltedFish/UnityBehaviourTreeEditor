using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "设置buffskill")]
    public class SetBuffSkill : Node
    {
        public SetBuffSkill(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("技能", typeof(Server.Skill))]
        public string BuffSkill;
    }
}
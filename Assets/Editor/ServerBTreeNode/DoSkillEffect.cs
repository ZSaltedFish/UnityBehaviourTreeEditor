using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "触发buff属性影响")]
    public class DoSkillEffect : Node
    {
        public DoSkillEffect(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("IsAdd")]
        public bool IsAdd;

        [NodeInput("Skill", typeof(Server.Skill))]
        public string Self;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Owner;
    }
}
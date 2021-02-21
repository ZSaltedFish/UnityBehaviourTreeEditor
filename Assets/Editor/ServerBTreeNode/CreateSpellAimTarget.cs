using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "对目标方向发动技能")]
    public class CreateSpellAimTarget : Node
    {
        public CreateSpellAimTarget(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("技能", typeof(int))]
        public string SpellID;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("目标", typeof(Server.Unit))]
        public string Target;
    }
}
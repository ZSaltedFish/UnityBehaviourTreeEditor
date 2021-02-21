using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "创建或发动技能(选择目标)")]
    public class CreateSpellTarget : Node
    {
        public CreateSpellTarget(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("技能", typeof(int))]
        public string SpellID;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("目标", typeof(Server.Unit))]
        public string Target;

        [NodeInput("力量", typeof(double))]
        public string Power;

    }
}
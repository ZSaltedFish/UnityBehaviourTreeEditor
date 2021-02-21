using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "创建或发动技能(带参数)")]
    public class CreateSpellWithArgs : Node
    {
        public CreateSpellWithArgs(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("技能", typeof(int))]
        public string SpellID;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("参数容器", typeof(Server.Args))]
        public string Args;
    }
}
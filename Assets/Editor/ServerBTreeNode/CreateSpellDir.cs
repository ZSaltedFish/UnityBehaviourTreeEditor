using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "创建或发动技能(指定方向)")]
    public class CreateSpellDir : Node
    {
        public CreateSpellDir(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("技能", typeof(int))]
        public string SpellID;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("方向", typeof(Vector3))]
        public string Dir;

        [NodeInput("力量", typeof(double))]
        public string Power;

    }
}
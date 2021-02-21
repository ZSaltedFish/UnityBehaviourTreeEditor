using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "高目标方向移动")]
    public class RunToDir : Node
    {
        public RunToDir(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("是否技能或buff")]
        public bool IsSpell;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("方向", typeof(Vector3))]
        public string Dir;
    }
}
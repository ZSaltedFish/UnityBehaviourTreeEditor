using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "本队中,是否最靠近目标")]
    public class IsClosest : Node
    {
        public IsClosest(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("目标 1球,2对方球门,3本方球门")]
        public int TargetType;

        [NodeField("包含守门员")]
        public bool with_keeper;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;
    }
}
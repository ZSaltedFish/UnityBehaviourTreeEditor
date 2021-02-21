using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "释放球(朝向)")]
    public class SetBallFree : Node
    {
        public SetBallFree(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("力量(默认)")]
        public double Power;

        [NodeInput("力量(可选)", typeof(double))]
        public string Power2;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("朝向", typeof(Vector3))]
        public string Dir;
    }
}
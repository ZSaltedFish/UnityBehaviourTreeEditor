using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "截球属性碰撞)")]
    public class CaptureCombat : Node
    {
        public CaptureCombat(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("截球者", typeof(Server.Unit))]
        public string Owner;

        [NodeInput("球", typeof(Server.Ball))]
        public string Ball;
    }
}
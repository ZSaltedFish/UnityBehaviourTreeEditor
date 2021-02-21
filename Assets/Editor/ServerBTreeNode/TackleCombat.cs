using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "铲球属性碰撞)")]
    public class TackleCombat : Node
    {
        public TackleCombat(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("铲球者", typeof(Server.Unit))]
        public string Owner;

        [NodeInput("控球者", typeof(Server.Unit))]
        public string Clter;
    }
}
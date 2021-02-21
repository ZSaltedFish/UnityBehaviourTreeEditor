using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "抢球属性碰撞)")]
    public class RabCombat : Node
    {
        public RabCombat(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("抢球者", typeof(Server.Unit))]
        public string Owner;

        [NodeInput("控球者", typeof(Server.Unit))]
        public string Clter;
    }
}
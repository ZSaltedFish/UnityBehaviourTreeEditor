using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "检查一个buff是或存在(Unit)")]
    public class CheckBuff : Node
    {
        public CheckBuff(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("BuffID")]
        public int BuffID;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

    }
}
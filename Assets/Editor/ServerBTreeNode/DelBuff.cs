using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "删除一个buff(Unit)")]
    public class DelBuff : Node
    {
        public DelBuff(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("BuffID")]
        public int BuffID;

        [NodeInput("BuffID(可选)", typeof(double))]
        public string InBuffID;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

    }
}
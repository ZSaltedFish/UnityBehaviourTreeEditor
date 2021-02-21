using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "重置操作状态")]
    public class ResetOperState : Node
    {
        public ResetOperState(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("球员", typeof(Server.Unit))]
        public string Unit;

    }
}
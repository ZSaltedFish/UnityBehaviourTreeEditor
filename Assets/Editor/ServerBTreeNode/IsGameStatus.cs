using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "检查当前游戏状态")]
    public class IsGameStatus : Node
    {
        public IsGameStatus(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("游戏状态")]
        public eGameStatus Status;
    }
}
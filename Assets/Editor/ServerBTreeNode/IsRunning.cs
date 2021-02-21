using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "游戏是否运行中")]
    public class IsRunning : Node
    {
        public IsRunning(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
    }
}
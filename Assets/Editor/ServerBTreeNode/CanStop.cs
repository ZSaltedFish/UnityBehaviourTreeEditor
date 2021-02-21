using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "检查是否可停止移动(球员)")]
    public class CanStop : Node
    {
        public CanStop(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;
    }
}
using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "恢复锁朝向lockface")]
    public class RecoverLockface : Node
    {
        public RecoverLockface(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

    }
}
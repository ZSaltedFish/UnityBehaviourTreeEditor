using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "unit是否受威胁")]
    public class IsThreatened : Node
    {
        public IsThreatened(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
    
        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

    }
}
using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "目标球员是否自己")]
    public class IsSelf : Node
    {
        public IsSelf(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("本人", typeof(Server.Unit))]
        public string Self;

        [NodeInput("目标球员", typeof(Server.Unit))]
        public string Unit;
    }
}
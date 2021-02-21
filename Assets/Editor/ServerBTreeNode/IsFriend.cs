using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "是否友方队员")]
    public class IsFriend : Node
    {
        public IsFriend(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("目标球员", typeof(Server.Unit))]
        public string Other;
        
    }
}
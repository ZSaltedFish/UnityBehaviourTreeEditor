using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "是否朝向相同")]
    public class IsSameDirection : Node
    {
        public IsSameDirection(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("目标", typeof(Server.Object))]
        public string Target;
    }
}
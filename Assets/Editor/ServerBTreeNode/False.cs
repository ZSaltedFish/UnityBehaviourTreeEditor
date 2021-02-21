using Model;

namespace ServerTree
{
    [Node(NodeClassifyType.Composite, "返回False")]
    public class False : Node
    {
        public False(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
    }
}
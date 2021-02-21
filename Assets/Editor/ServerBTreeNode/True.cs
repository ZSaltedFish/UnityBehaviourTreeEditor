using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Composite, "返回True")]
    public class True : Node
    {
        public True(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
    }
}
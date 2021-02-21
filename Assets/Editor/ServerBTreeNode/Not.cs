using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Composite, "反向返回结果")]
    public class Not : Node
    {
        public Not(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
    }
}
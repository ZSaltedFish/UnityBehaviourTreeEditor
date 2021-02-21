using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Composite, "队列节点")]
    public class Sequence : Node
    {
        public Sequence(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("强制返回")]
        public eForceReturn ForceRet;
    }
}
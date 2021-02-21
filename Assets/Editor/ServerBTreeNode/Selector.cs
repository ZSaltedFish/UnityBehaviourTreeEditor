using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Composite, "选择节点")]
    public class Selector : Node
    {
        public Selector(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("强制返回")]
        public eForceReturn ForceRet;
    }
}
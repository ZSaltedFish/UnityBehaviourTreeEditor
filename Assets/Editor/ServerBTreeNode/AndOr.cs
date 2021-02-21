using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Composite, "三目运算")]
    public class AndOr : Node
    {
        public AndOr(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("强制返回")]
        public eForceReturn ForceRet;
    }
}
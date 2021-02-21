using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Composite, "不执行")]
    public class NotRun : Node
    {
        public NotRun(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("强制返回")]
        public eForceReturn ForceRet;
    }
}
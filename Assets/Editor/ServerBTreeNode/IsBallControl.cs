using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "是否控球者")]
    public class IsBallControl : Node
    {
        public IsBallControl(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("true最后持球,false为当前持球")]
        public bool IsLast;
        
        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;
        
    }
}
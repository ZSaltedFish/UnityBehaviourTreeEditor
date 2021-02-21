using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "设置控制权")]
    public class AddCtrlBuff : Node
    {
        public AddCtrlBuff(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;
    }
}
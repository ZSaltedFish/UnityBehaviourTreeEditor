using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "设置射门标志(用于触发防守必杀技)")]
    public class SetShootFlag : Node
    {
        public SetShootFlag(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("本人", typeof(Server.Unit))]
        public string Self;
    }
}
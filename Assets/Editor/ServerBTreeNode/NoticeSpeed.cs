using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "通知速度改变")]
    public class NoticeSpeed : Node
    {
        public NoticeSpeed(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("球员", typeof(Server.Object))]
        public string Self;
        
    }
}
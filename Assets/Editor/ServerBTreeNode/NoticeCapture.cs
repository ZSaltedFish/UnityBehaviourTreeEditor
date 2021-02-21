using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "通知捕获球")]
    public class NoticeCapture : Node
    {
        public NoticeCapture(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("球员", typeof(Server.Object))]
        public string Self;
        
    }
}
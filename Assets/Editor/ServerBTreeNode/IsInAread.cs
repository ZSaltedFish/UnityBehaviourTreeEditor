using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "是否在特定区域")]
    public class IsInAread : Node
    {
        public IsInAread(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("区域 1本方半场,2对方半场,3本方禁区,2对方禁区")]
        public int AreaType;

        [NodeInput("对象", typeof(Server.Object))]
        public string Self;
        
    }
}
using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取球对象")]
    public class GetBall : Node
    {
        public GetBall(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeOutput("球", typeof(Server.Ball))]
        public string Ball;
    }
}
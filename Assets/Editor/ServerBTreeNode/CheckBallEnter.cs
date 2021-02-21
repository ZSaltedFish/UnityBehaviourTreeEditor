using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "检查球是否可能进入球门")]
    public class CheckBallEnter : Node
    {
        public CheckBallEnter(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("球门", typeof(Server.Goal))]
        public string Goal;

        [NodeInput("球", typeof(Server.Ball))]
        public string Ball;

        [NodeOutput("位置", typeof(Vector3))]
        public string Cross;
    }
}
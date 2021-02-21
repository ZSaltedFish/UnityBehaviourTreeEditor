using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "取球移动方向")]
    public class GetBallDirection : Node
    {
        public GetBallDirection(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("是否前进方向")]
        public bool Forward;

        [NodeInput("球", typeof(Server.Ball))]
        public string Ball;

        [NodeOutput("方向", typeof(Vector3))]
        public string Dir;
    }
}
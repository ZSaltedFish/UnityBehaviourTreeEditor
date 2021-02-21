using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "取球的反弹方向(射门撞人)")]
    public class GetBallRebound : Node
    {
        public GetBallRebound(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("球", typeof(Server.Ball))]
        public string Ball;

        [NodeOutput("方向", typeof(Vector3))]
        public string Dir;

        [NodeOutput("反弹力量", typeof(double))]
        public string Power;
        
    }
}
using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "取球的下一个位置")]
    public class GetBallNext : Node
    {
        public GetBallNext(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("预测球飞行时间(毫秒)")]
        public double Time;

        [NodeInput("预测球飞行时间(毫秒)(可选)", typeof(double))]
        public string InTime;

        [NodeInput("球", typeof(Server.Ball))]
        public string Ball;

        [NodeOutput("输出位置", typeof(Server.Vector3))]
        public string Pos;
    }
}
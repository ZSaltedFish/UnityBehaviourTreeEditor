using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "检查球穿越球员")]
    public class CheckBallCross : Node
    {
        public CheckBallCross(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("预测球飞行时间(毫秒)")]
        public double Time;

        [NodeField("高度差")]
        public double Height;

        [NodeField("距离")]
        public double Dis;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("球", typeof(Server.Ball))]
        public string Ball;

        [NodeOutput("碰撞位置", typeof(Server.Vector3))]
        public string ImpactPos;
    }
}
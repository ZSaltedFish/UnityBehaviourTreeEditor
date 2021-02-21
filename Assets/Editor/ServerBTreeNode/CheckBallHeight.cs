using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "检查球高度")]
    public class CheckBallHeight : Node
    {
        public CheckBallHeight(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("高: 正数为大于,负数为小于")]
        public double Height;

        [NodeInput("位置(可选)", typeof(Server.Vector3))]
        public string Pos;

        [NodeInput("球(可选)", typeof(Server.Ball))]
        public string Ball;
    }
}
using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "取最靠近球门的坐标点")]
    public class GetClosestGoalPos : Node
    {
        public GetClosestGoalPos(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("对象", typeof(Server.Object))]
        public string Self;

        [NodeInput("球门", typeof(Server.Goal))]
        public string Goal;

        [NodeOutput("输出位置", typeof(Server.Vector3))]
        public string Pos;
    }
}
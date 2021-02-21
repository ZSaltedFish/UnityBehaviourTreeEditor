using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "取守门员扑球点(丢球时)")]
    public class CheckKeeperRob : Node
    {
        public CheckKeeperRob(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("球位置", typeof(Server.Vector3))]
        public string BallPos;

        [NodeOutput("目标位置", typeof(Server.Vector3))]
        public string Pos;
    }
}
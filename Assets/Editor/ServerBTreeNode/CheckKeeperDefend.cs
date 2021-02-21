using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "守门员防守数值计算")]
    public class CheckKeeperDefend : Node
    {
        public CheckKeeperDefend(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("球", typeof(Server.Ball))]
        public string Ball;

        [NodeOutput("是否能抓住球", typeof(double))]
        public string Grab;
    }
}
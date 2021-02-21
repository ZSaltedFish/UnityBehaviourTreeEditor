using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取传球目标")]
    public class GetPassTarget : Node
    {
        public GetPassTarget(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("球", typeof(Server.Ball))]
        public string Ball;

        [NodeOutput("球员", typeof(Server.Unit))]
        public string Other;
    }
}
using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "取到目标点的传球力量")]
    public class GetPassPower : Node
    {
        public GetPassPower(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("目标位置", typeof(Server.Vector3))]
        public string Pos;

        [NodeInput("目标", typeof(Server.Object))]
        public string Target;

        [NodeOutput("力度", typeof(double))]
        public string Power;
    }
}
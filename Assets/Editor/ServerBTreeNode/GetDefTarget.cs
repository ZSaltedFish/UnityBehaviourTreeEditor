using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "获取防守目标")]
    public class GetDefTarget : Node
    {
        public GetDefTarget(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("防守目标", typeof(Server.Unit))]
        public string Unit;
        
    }
}
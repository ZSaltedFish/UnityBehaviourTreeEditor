using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "从球的位置获取AI跑位位置")]
    public class GetAIPosFromUnit : Node
    {
        public GetAIPosFromUnit(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("位置", typeof(Vector3))]
        public string Pos;
    }
}
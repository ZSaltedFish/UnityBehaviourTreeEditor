using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取3号位球员的位置")]
    public class GetFreemanPos : Node
    {
        public GetFreemanPos(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("需要协助的队员", typeof(Server.Unit))]
        public string Other;

        [NodeOutput("位置", typeof(Vector3))]
        public string Pos;
    }
}
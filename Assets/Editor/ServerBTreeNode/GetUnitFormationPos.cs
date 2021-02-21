using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "根据阵型进行跑位")]
    public class GetUnitFormationPos : Node
    {
        public GetUnitFormationPos(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("位置", typeof(Vector3))]
        public string OutPos;
    }
}
using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取球落点位置")]
    public class GetBallDest : Node
    {
        public GetBallDest(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeOutput("位置", typeof(Vector3))]
        public string Pos;
    }
}
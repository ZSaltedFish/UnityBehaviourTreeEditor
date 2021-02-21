using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "取出生位置")]
    public class GetBornPos : Node
    {
        public GetBornPos(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("位置", typeof(Vector3))]
        public string Pos;
    }
}
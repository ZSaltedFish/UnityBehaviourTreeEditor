using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "取守门员原位(默认站立位置)")]
    public class GetKeeperPos : Node
    {
        public GetKeeperPos(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("位置", typeof(Vector3))]
        public string Pos;
    }
}
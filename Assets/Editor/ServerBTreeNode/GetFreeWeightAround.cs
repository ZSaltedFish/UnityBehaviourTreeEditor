using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取未被敌方的位置")]
    public class GetFreeWeightAround : Node
    {
        public GetFreeWeightAround(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("位置坐标", typeof(Vector3))]
        public string Pos;
    }
}
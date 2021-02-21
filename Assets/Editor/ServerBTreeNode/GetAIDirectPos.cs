using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "取AI直线位置")]
    public class GetAIDirectPos : Node
    {
        public GetAIDirectPos(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("输出位置", typeof(Vector3))]
        public string OutPos;
    }
}
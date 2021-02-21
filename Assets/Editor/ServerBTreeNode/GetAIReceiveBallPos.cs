using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取AI接球位置")]
    public class GetAIReceiveBallPos : Node
    {
        public GetAIReceiveBallPos(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }


        [NodeField("true向前策应,false为向后策应")]
        public bool IsForword;

        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("需要协助的队员", typeof(Server.Unit))]
        public string Other;


        [NodeOutput("位置", typeof(Vector3))]
        public string Pos;
    }
}
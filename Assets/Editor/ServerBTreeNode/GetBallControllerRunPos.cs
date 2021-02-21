using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取AI带球球员的走位")]
    public class GetBallControllerRunPos : Node
    {
        public GetBallControllerRunPos(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("参考跑位的队友", typeof(Server.Unit))]
        public string Other;

        [NodeOutput("位置", typeof(Vector3))]
        public string Pos;
    }
}
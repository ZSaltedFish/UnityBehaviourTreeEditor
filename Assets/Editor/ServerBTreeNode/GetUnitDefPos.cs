using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "根据防守对象获取防守位置")]
    public class GetUnitDefPos : Node
    {
        public GetUnitDefPos(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("目标球员", typeof(Server.Unit))]
        public string Other;

        [NodeOutput("位置", typeof(Vector3))]
        public string OutPos;
    }
}
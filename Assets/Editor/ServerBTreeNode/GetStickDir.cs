using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取摇杆操作方向")]
    public class GetStickDir : Node
    {
        public GetStickDir(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("是否取锁定摇杆")]
        public bool Lock;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Unit;

        [NodeOutput("方向", typeof(Vector3))]
        public string Dir;
    }
}
using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取场景对象位置")]
    public class GetObjectPos : Node
    {
        public GetObjectPos(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("是否目标位置(否为原位置)")]
        public bool IsDest;

        [NodeInput("场景对象", typeof(Server.Object))]
        public string Self;

        [NodeOutput("位置", typeof(Vector3))]
        public string Pos;
    }
}
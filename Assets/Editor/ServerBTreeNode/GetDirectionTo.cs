using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取对象到目标对象的朝向")]
    public class GetDirectionTo : Node
    {
        public GetDirectionTo(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("场景对象", typeof(Server.Object))]
        public string Self;

        [NodeInput("目标对象(可选)", typeof(Server.Object))]
        public string Target;

        [NodeInput("位置(可选)", typeof(Vector3))]
        public string Pos;

        [NodeOutput("方向", typeof(Vector3))]
        public string Dir;
    }
}
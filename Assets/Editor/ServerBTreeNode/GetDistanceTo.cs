using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取对象对于指定位置的距离")]  
    public class GetDistanceTo : Node
    {
        public GetDistanceTo(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("场景对象", typeof(Server.Object))]
        public string Self;

        [NodeInput("目标对象(可选)", typeof(Server.Object))]
        public string Target;

        [NodeInput("位置(可选)", typeof(Vector3))]
        public string Pos;

        [NodeOutput("距离", typeof(double))]
        public string Dis;
    }
}
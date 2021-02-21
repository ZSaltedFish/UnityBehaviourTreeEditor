using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "检查目标位置是否指定反向的角度内")]
    public class WithInDirection : Node
    {
        public WithInDirection(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("角度(是否在此角度内)")]
        public double Angle;

        [NodeInput("源对象", typeof(Server.Object))]
        public string Self;

        [NodeInput("源方向(可选)", typeof(Vector3))]
        public string Dir;

        [NodeInput("目标位置(可选)", typeof(Vector3))]
        public string Pos;

        [NodeInput("目标对象(可选)", typeof(Server.Object))]
        public string Target;
    }
}
using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "检查单位是否在一定范围内")]
    public class WithInDistance : Node
    {
        public WithInDistance(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("范围大小(单位米)")]
        public double Dis;

        [NodeField("高度差(为0不算高度)")]
        public double Height;

        [NodeInput("范围大小(可选)(单位米)", typeof(double))]
        public string InDis;

        [NodeInput("源位置(可选)", typeof(Vector3))]
        public string Sour;

        [NodeInput("源对象(可选)", typeof(Server.Object))]
        public string Self;

        [NodeInput("目标位置(可选)", typeof(Vector3))]
        public string Pos;

        [NodeInput("目标对象(可选)", typeof(Server.Object))]
        public string Target;
    }
}
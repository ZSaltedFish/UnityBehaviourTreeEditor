using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "取对象在另一对象夹角")]
    public class GetAngleFrom : Node
    {
        public GetAngleFrom(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("是否检测方向(取目标/源方向)")]
        public bool IsDir;

        [NodeInput("原对象", typeof(Server.Object))]
        public string Self;

        [NodeInput("目标(可选)", typeof(Server.Object))]
        public string Target;

        [NodeInput("位置(可选)", typeof(Server.Vector3))]
        public string Pos;

        [NodeInput("方向(可选)", typeof(Server.Vector3))]
        public string Dir;

        [NodeOutput("输出角度", typeof(double))]
        public string Angle;

        [NodeOutput("输出边 1顺,-1逆", typeof(double))]
        public string Side;
    }
}
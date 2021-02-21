using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "取指定方向上其它单位")]
    public class GetUnitInDirection : Node
    {
        public GetUnitInDirection(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("0为所有人, 1队友, 2敌人")]
        public int UType;

        [NodeField("角度")]
        public int Angle;

        [NodeField("距离")]
        public double Distance;

        [NodeField("0空 1最近 2最远")]
        public int Nearest;

        [NodeField("0空 1靠中间 2最靠边缘")]
        public int Mostdirect;

        [NodeField("0空 1最优 2最差(分数 = 角度+距离*权重)")]
        public int Best;

        [NodeField("忽略守门员")]
        public bool IgnoreKeeper;

        [NodeField("忽略无敌")]
        public bool IgnoreGod;

        [NodeField("包含自己")]
        public bool ContainSelf;

        [NodeInput("角度(可选)", typeof(double))]
        public string InAngle;

        [NodeInput("距离(可选)", typeof(double))]
        public string InDistance;

        [NodeInput("原点对象", typeof(Server.Object))]
        public string Self;

        [NodeInput("方向", typeof(Server.Vector3))]
        public string Dir;

        [NodeOutput("所有人(可选)", typeof(Server.List))]
        public string List;

        [NodeOutput("目标球员(可选)", typeof(Server.Unit))]
        public string Other;

    }
}
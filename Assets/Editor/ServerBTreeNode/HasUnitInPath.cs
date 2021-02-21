using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "到某点的方向上是否有其它单位")]
    public class HasUnitInPath : Node
    {
        public HasUnitInPath(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("0为所有人, 1队友, 2敌人")]
        public int UType;

        [NodeField("忽略守门员")]
        public bool IgnoreKeeper;

        [NodeField("角度")]
        public int Angle;

        [NodeInput("原点对象", typeof(Server.Object))]
        public string Self;

        [NodeInput("目标位置(可选)", typeof(Server.Vector3))]
        public string Pos;

        [NodeInput("目标(可选)", typeof(Server.Object))]
        public string Target;

    }
}
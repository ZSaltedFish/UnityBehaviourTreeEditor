using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "到某点的线路上是否有其它单位")]
    public class HasUnitInLine : Node
    {
        public HasUnitInLine(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("0为所有人, 1队友, 2敌人")]
        public int UType;

        [NodeField("宽度(米)")]
        public double Width;

        [NodeField("忽略守门员")]
        public bool IgnoreKeeper;

        [NodeInput("原点对象", typeof(Server.Object))]
        public string Self;

        [NodeInput("目标位置(可选)", typeof(Server.Vector3))]
        public string Pos;

        [NodeInput("目标(可选)", typeof(Server.Object))]
        public string Target;

    }
}
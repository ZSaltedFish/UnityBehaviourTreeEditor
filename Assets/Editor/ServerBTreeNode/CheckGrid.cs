using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "检查自己位置(格子)是否大于x")]
    public class CheckGrid : Node
    {
        public CheckGrid(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("格子")]
        public double Grid;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;
    }
}
using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Composite, "执行输入的列表")]
    public class Loot : Node
    {
        public Loot(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("列表", typeof(Server.List))]
        public string List;

        [NodeOutput("球员", typeof(Server.Unit))]
        public string Value;
    }
}
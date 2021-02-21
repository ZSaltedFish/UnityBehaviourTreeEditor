using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Root, "球员AI根节点")]
    public class UnitRoot : Node
    {
        public UnitRoot(NodeProto nodeProto) : base(nodeProto) { }
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeOutput("所有者", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("球", typeof(Server.Ball))]
        public string Ball;

        [NodeOutput("Any", typeof(BeHaviourAnyType))]
        public string Null;
        

    }
}

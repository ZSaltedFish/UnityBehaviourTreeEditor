using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Root, "AI根节点(通用)")]
    public class BaseRoot : Node
    {
        public BaseRoot(NodeProto nodeProto) : base(nodeProto) { }
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeOutput("Any", typeof(BeHaviourAnyType))]
        public string Null;

    }
}

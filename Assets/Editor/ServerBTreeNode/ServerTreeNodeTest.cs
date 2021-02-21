using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Root, "test")]
    public class ServerTreeNodeTest : Node
    {



        public ServerTreeNodeTest(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env){return true;}
    }
}

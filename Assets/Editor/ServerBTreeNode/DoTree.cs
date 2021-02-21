using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "执行子树")]
    public class DoTree : Node
    {
        public DoTree(NodeProto nodeProto) : base(nodeProto) { }
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("子树名", envKeyType = typeof(ServerSubTree))]
        public string Script;

        [NodeInput("所有者球员", typeof(Server.Unit))]
        public string Owner;
        

    }
}

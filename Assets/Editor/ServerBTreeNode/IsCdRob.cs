using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "抢球状态是否cd中")]
    public class IsCdRob : Node
    {
        public IsCdRob(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("场景对象(球员或球)", typeof(Server.Object))]
        public string Self;
    }
}
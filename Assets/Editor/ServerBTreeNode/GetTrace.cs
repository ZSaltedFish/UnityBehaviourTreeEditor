using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取是否跟随")]
    public class GetTrace : Node
    {
        public GetTrace(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("球员", typeof(Server.Unit))]
        public string Unit;
        
    }
}
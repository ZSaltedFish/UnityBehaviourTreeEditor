using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "是否是队伍最前面")]  
    public class IsHeadmost : Node
    {
        public IsHeadmost(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;

      
    }
}
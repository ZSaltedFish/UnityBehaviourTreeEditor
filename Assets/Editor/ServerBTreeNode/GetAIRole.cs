using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取AI角色")]
    public class GetAIRole : Node
    {
        public GetAIRole(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;


    }
}
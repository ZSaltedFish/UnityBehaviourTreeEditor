using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "获取分配的角色")]
    public class GetRole : Node
    {
	  

		public GetRole(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;
        //[NodeOutput("角色", typeof(double))]
        //public string Role;

    }
}

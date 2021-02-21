using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "根据role获取unit")]
    public class GetUnitByRole : Node
    {
        public GetUnitByRole(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("角色id")]
        public int Role;

        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("球员", typeof(Server.Unit))]
        public string Unit;
        
    }
}
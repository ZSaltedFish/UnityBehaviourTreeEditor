using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "取最靠近自己的敌方成员")]
    public class GetClosestEnemy : Node
    {
        public GetClosestEnemy(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("最近敌人", typeof(Server.Unit))]
        public string Other;
    }
}
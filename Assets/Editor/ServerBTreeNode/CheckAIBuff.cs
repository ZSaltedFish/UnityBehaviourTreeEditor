using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "添加一个buff(AI)")]
    public class CheckAIBuff : Node
    {
        public CheckAIBuff(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }



        [NodeField("AIBuff")]
        public eAIBuff AIBuff;

        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;

      



    }
}
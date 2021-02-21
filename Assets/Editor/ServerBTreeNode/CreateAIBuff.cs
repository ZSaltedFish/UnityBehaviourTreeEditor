using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "添加一个buff(AI)")]
    public class CreateAIBuff : Node
    {
        public CreateAIBuff(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("AIBuff")]
        public eAIBuff AIBuff;

        [NodeField("Buff持续时间(可选)")]
        public int BuffTime;

        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;
        
      



    }
}
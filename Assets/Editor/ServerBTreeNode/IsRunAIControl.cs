using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "是否运行AI或控制")]
    public class IsRunAIControl : Node
    {
        public IsRunAIControl(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;

        [NodeField("1:AI；2:控制；3抢无主球")]
        public int IsAI;
    }
}
using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "比较两个值(输入值:比较值)")]
    public class Compare : Node
    {
        public Compare(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("比较类型")]
        public eOperator Operator;

        [NodeField("比较值")]
        public double CheckValue;

        [NodeInput("输入值", typeof(double))]
        public string Value;

        [NodeInput("比较值(可选)", typeof(double))]
        public string InCheckValue;
    }
}
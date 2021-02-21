using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "输出一个指定值,用于输入")]
    public class OutputValue : Node
    {
        public OutputValue(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeField("指定值")]
        public double Value;

        [NodeOutput("输出值", typeof(double))]
        public string OutValue;
    }
}
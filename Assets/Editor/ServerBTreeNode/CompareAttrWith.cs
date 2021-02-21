using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "比较指定对象上的属性(输入比较值)")]
    public class CompareAttrWith : Node
    {
        public CompareAttrWith(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("属性")]
        public eAttr Attr;

        [NodeField("比较类型")]
        public eOperator Operator;

        [NodeInput("比较值", typeof(double))]
        public string CheckValue;

        [NodeInput("对象", typeof(Server.Object))]
        public string Self;
    }
}
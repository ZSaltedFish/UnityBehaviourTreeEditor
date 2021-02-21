using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "取对象属性")]
    public class GetAttr : Node
    {
        public GetAttr(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("属性")]
        public eAttr Attr;

        [NodeInput("场景对象", typeof(Server.Object))]
        public string Self;

        [NodeOutput("值", typeof(double))]
        public string Value;
    }
}
using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "改变对象属性")]
    public class ChangeAttr : Node
    {
        public ChangeAttr(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("属性")]
        public eAttr Attr;

        [NodeField("改变值")]
        public double Value;

        [NodeInput("场景对象(球员或球)", typeof(Server.Object))]
        public string Self;
    }
}
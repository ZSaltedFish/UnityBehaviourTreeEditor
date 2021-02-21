using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "改变对象属性(输入值)")]
    public class ChangeAttrWith : Node
    {
        public ChangeAttrWith(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("属性")]
        public eAttr Attr;

        [NodeInput("值", typeof(double))]
        public string Value;

        [NodeInput("场景对象(球员或球)", typeof(Server.Object))]
        public string Self;
    }
}
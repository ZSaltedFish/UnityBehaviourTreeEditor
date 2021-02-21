using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取技能或buff参数")]
    public class GetArgs : Node
    {
        public GetArgs(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("属性")]
        public string Attr;

        [NodeInput("容器", typeof(Server.Args))]
        public string Args;

        [NodeOutput("输出值", typeof(System.Object))]
        public string Value;
    }
}
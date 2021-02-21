using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "创建参数列表(用于添加和传参给skill和buff)")]
    public class CreateArgs : Node
    {
        public CreateArgs(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeOutput("容器", typeof(Server.Args))]
        public string Args;
    }
}
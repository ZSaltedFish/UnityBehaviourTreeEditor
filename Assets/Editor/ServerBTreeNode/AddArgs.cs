using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "添加一个参数")]
    public class AddArgs : Node
    {
        public AddArgs(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("属性")]
        public string Attr;

        [NodeInput("容器", typeof(Server.Args))]
        public string Args;

        [NodeInput("输入值", typeof(System.Object))]
        public string Value;
        
    }
}
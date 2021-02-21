using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "添加一个参数(数字)")]
    public class AddArgsNumber : Node
    {
        public AddArgsNumber(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("属性")]
        public string Attr;

        [NodeField("输入值")]
        public double Value;

        [NodeInput("输入值(可选)", typeof(double))]
        public string InValue;

        [NodeInput("容器", typeof(Server.Args))]
        public string Args;
        
    }
}
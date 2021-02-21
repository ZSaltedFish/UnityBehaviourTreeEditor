using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "根据buff持续时间和当前时间做插值")]
    public class BuffLerpValue : Node
    {
        public BuffLerpValue(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("开始值", typeof(double))]
        public string BeginV;

        [NodeInput("结束值", typeof(double))]
        public string EndV;

        [NodeInput("buff对象", typeof(Server.Buff))]
        public string Self;

        [NodeOutput("输出值", typeof(double))]
        public string Value;

    }
}
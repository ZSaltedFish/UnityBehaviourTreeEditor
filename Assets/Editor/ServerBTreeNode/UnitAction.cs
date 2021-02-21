using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "球员创建动作")]
    public class UnitAction : Node
    {
        public UnitAction(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("动作类型")]
        public eUAction Action;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("参数容器", typeof(Server.Args))]
        public string Args;
    }
}
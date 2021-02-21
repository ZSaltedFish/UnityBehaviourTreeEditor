using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "设置时间暂停或开始")]
    public class SetFreezeTime : Node
    {
        public SetFreezeTime(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("冷却时间(毫秒)", typeof(double))]
        public string FreezeTime;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Owner;

    }
}
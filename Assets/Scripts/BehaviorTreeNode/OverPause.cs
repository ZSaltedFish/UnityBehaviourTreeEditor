using System;

namespace Model
{
    [Node(NodeClassifyType.Action, "结束暂停时间")]
    public class OverPause : Node
    {
        public OverPause(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            return true;
        }
    }
}

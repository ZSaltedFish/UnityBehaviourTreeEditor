namespace Model
{
    [Node(NodeClassifyType.Action, "新手引导UI可见性")]
    public class GuideUIEnable : Node
    {
        [NodeField("Visible")]
        public bool State;
        public GuideUIEnable(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Game.EventSystem.Run(EventIdType.GuideUIVisible, State);
            return true;
        }
    }
}

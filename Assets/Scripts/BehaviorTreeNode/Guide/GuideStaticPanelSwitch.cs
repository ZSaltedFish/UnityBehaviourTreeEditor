namespace Model
{
    [Node(NodeClassifyType.Action, "新手引导开关比分界面")]
    public class GuideStaticPanelSwitch : Node
    {
        [NodeField("比分界面开关")]
        public bool Switch;

        public GuideStaticPanelSwitch(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Game.EventSystem.Run(EventIdType.GuideStaticPanelSwitch, Switch);
            return true;
        }
    }
}

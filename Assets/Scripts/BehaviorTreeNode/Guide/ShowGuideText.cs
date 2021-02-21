namespace Model
{
    [Node(NodeClassifyType.Action, "设置引导界面显示状态")]
    public class GuidePanelState : Node
    {
        [NodeField("开关")]
        public bool state;

        public GuidePanelState(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Game.EventSystem.Run(EventIdType.ShowGuidePanel, state);
            return true;
        }
    }
}

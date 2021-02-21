namespace Model
{
    [Node(NodeClassifyType.Action, "初始化新手引导数据")]
    public class InitGuideInfo : Node
    {
        [NodeField("当次引导总步骤数")]
        public int SubTotalStep;
        [NodeField("当次引导名称")]
        public string Title;

        public InitGuideInfo(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //GuideComponent.Instance.Name = Title;
            //GuideComponent.Instance.SubTotalStep = SubTotalStep;
            //Game.EventSystem.Run(EventIdType.GuideTitleChange);
            return true;
        }
    }
}

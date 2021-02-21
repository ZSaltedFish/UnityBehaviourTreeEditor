namespace Model
{
    [Node(NodeClassifyType.Action, "新手引导全部结束")]
    public class GuideAllOver : Node
    {
        public GuideAllOver(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //GuideComponent.Instance.GuideOver();
            return true;
        }
    }
}

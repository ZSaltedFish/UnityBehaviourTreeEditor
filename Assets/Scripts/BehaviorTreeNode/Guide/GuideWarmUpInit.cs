namespace Model
{
    [Node(NodeClassifyType.Action, "新手引导热身赛初始化")]
    public class GuideWarmUpInit : Node
    {
        public GuideWarmUpInit(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //GameStateComponent.Instance.IsGuide = false;
            return true;
        }
    }
}

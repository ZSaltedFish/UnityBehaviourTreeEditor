namespace Model
{
    [Node(NodeClassifyType.Condition, "热身赛是否结束")]
    public class GuideGameOver : Node
    {
        public GuideGameOver(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //return GuideComponent.Instance.IsEnd;
            return true;
        }
    }
}

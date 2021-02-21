namespace Model
{
    [Node(NodeClassifyType.Action, "删除一个新手引导特效")]
    public class RemoveGuideEffect : Node
    {
        [NodeField("名字索引")]
        public string Name;

        public RemoveGuideEffect(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //GuideComponent.Instance.RemoveEffect(Name);
            return true;
        }
    }
}

namespace Model
{
    [Node(NodeClassifyType.Action, "进入下一步行为树")]
    public class GuideToNextTree : Node
    {
        public GuideToNextTree(NodeProto p)
            : base(p) { }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //GuideComponent.Instance.ToNextGuideTree();
            return true;
        }
    }
}

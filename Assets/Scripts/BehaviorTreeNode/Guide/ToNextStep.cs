namespace Model
{
    [Node(NodeClassifyType.Action, "进入下一个引导步骤")]
    public class ToNextStep : Node
    {
        public ToNextStep(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //GuideComponent.Instance.NextStep();
            return true;
        }
    }
}

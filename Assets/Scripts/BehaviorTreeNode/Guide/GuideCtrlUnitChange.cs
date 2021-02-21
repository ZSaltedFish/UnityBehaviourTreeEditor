namespace Model
{
    [Node(NodeClassifyType.Condition, "控球单位改变")]
    public class GuideCtrlUnitChange : Node
    {
        public GuideCtrlUnitChange(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //return GuideComponent.Instance.IsControlUnitChange;
            return true;
        }
    }
}

namespace Model
{
    public enum QualityType
    {
        High_60Hz_ShadowEnable = 2,
        Middle_30Hz_ShadowEnable = 1,
        Low_30Hz_ShadowDisable = 0
    }

    [Node(NodeClassifyType.Condition, "图形等级")]
    public class QualityTypeCondition : Node
    {
        [NodeField("判断的图形等级")]
        public QualityType QualityValue;

		public QualityTypeCondition(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            return true;
        }
    }
}

namespace Model
{
    [Node(NodeClassifyType.Action, "改变一个Numeric值")]
    public class NumericChange : Node
    {
        [NodeField("数值")]
        public int Value;
        [NodeField("Numeric类型")]
        public NumericType NType;
        [NodeInput("对象", typeof(Unit))]
        public string UnitName;
        public NumericChange(NodeProto nodeProto): base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            Unit unit = env.Get<Unit>(UnitName);
            //unit.GetComponent<NumericComponent>()[NType] = Value;
            return true;
        }
    }
}

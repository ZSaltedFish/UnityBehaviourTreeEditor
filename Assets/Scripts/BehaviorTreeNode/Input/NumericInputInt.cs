namespace Model
{
    [Node(NodeClassifyType.DataTransform, "Numeric数据转换到Data数据")]
    public class NumericInput : Node
    {
        [NodeField("输入类型")]
        public NumericType Numeric;
        [NodeInput("角色", typeof(Unit))]
        public string UnitName;
        [NodeOutput("输出名字", typeof(int))]
        public string DataOutput;
        public NumericInput(NodeProto nodeProto): base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit unit = env.Get<Unit>(UnitName);
            //NumericComponent numComp = unit.GetComponent<NumericComponent>();
            //int data = numComp.GetAsInt(Numeric);
            //env.Add(DataOutput, data);
            return true;
        }
    }
}

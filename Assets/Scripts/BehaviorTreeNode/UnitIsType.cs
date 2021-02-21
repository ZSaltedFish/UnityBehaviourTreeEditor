namespace Model
{
    [Node(NodeClassifyType.Condition, "判断Unit的类型")]
    public class UnitIsType : Node
    {
        [NodeField("Unit ID")]
        public int UnitID;

        [NodeInput("Unit Name", typeof(Unit))]
        public string UnitName;

        public UnitIsType(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit unit = env.Get<Unit>(UnitName);
            //return unit.GetConfig<UnitMonoConfig>().Id == UnitID;
            return true;
        }
    }
}

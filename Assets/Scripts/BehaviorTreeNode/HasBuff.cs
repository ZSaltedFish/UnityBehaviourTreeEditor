namespace Model
{
    [Node(NodeClassifyType.Condition, "判断是否有buff")]
    public class HasBuff : Node
    {
        [NodeInput("Unit", typeof(Unit))]
        public string UnitKey;

        [NodeField("buff所有者")]
        public int BuffConfigId;

        public HasBuff(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //   Unit unit = env.Get<Unit>(UnitKey);
            //return unit.GetComponent<BuffComponent>().HasBuff(this.BuffConfigId);
            return true;
        }
    }
}

namespace Model
{
    [Node(NodeClassifyType.Action, "Unit remove Buff")]
    public class RemoveBuff : Node
    {
        [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

        [NodeField("buff config id")]
        public int BuffConfigId;

        public RemoveBuff(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = env.Get<Unit>(UnitKey);
         //   unit.GetComponent<BuffComponent>().RemoveType(this.BuffConfigId);
            return true;
        }
    }
}

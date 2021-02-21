namespace Model
{
    [Node(NodeClassifyType.Condition, "是否锁住了方向")]
    public class IsLockTurn : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

		public IsLockTurn(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit unit = env.Get<Unit>(this.UnitKey);
            //return unit.GetComponent<MotorComponent>().IsLockTurn;
            return true;
        }
    }
}

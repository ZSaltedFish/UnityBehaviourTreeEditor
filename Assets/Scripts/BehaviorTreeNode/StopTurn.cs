namespace Model
{
    [Node(NodeClassifyType.Condition, "停止转向")]
    public class StopTurn : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;
		
		public StopTurn(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = env.Get<Unit>(this.UnitKey);
	        //unit.GetComponent<MotorComponent>()?.StopTurn();
			return true;
        }
    }
}

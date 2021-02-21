namespace Model
{
    [Node(NodeClassifyType.Condition, "停止移动")]
    public class StopMove : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;
		
		public StopMove(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
			//Unit unit = env.Get<Unit>(this.UnitKey);
	  //      unit.GetComponent<MotorComponent>()?.Stop();
	  //      unit.GetComponent<FootballMotorComponent>()?.Stop();
			return true;
        }
    }
}

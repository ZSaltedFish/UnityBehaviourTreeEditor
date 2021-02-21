namespace Model
{
    [Node(NodeClassifyType.Condition, "是否是传球的目标")]
    public class IsPassTarget : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

		public IsPassTarget(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
			//      Unit unit = env.Get<Unit>(this.UnitKey);
			//      Unit football = FootBallHelper.GetFootBall();
			//      Unit target = football.GetComponent<PassComponent>().Target;
			//      if (target == null)
			//      {
			//       return false;
			//      }
			//return unit.Id == target.Id;
			return true;
        }
    }
}

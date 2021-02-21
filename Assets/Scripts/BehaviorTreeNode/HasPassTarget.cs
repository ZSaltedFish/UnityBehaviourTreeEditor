namespace Model
{
    [Node(NodeClassifyType.Condition, "球是否有传球的目标")]
    public class HasPassTarget : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

		public HasPassTarget(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit football = FootBallHelper.GetFootBall();
	        //Unit target = football.GetComponent<PassComponent>().Target;
	        //if (target == null)
	        //{
		       // return false;
	        //}
			return true;
        }
    }
}

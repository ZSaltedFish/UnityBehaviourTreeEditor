namespace Model
{
    [Node(NodeClassifyType.Condition, "获取足球")]
    public class GetFootball : Node
    {
	    [NodeOutput("足球", typeof(Unit))]
	    public string FootballKey;

		public GetFootball(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	  //      Unit football = FootBallHelper.GetFootBall();
	  //      if (football == null)
	  //      {
		 //       return false;
	  //      }
			//env.Add(this.FootballKey, football);
			return true;
        }
    }
}

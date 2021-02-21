namespace Model
{
    [Node(NodeClassifyType.Action, "是否是主场,传入team")]
    public class IsHomeTeam : Node
    {
	    [NodeInput("Team", typeof(int))]
	    public string Team;

		public IsHomeTeam(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        int team = env.Get<int>(this.Team);
	        return team == 1;
        }
    }
}

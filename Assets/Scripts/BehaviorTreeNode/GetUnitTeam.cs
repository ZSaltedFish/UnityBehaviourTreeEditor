namespace Model
{
    [Node(NodeClassifyType.Action, "获取Team")]
    public class GetUnitTeam : Node
    {
        [NodeInput("Unit", typeof(Unit))]
        public string UnitKey;

	    [NodeOutput("Team", typeof(int))]
	    public string TeamKey;

		public GetUnitTeam(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	  //      Unit unit = env.Get<Unit>(this.UnitKey);
			//env.Add(this.TeamKey, unit.Actor.Team);
            return true;
        }
    }
}

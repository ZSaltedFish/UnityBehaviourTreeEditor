namespace Model
{
    [Node(NodeClassifyType.Condition, "add float")]
    public class IsLastGoalUnit : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

		public IsLastGoalUnit(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = env.Get<Unit>(this.UnitKey);
	        //long lastGoalUnitId = SceneHelper.Scene.GetComponent<GameStateComponent>().LastGoalUnitID;
	        //if (unit.Id == lastGoalUnitId)
	        //{
		       // return true;
	        //}
	        return false;
        }
    }
}

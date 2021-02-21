namespace Model
{
    [Node(NodeClassifyType.Condition, "获取最后进球的球员")]
    public class GetLastGoalUnit : Node
    {
	    [NodeOutput("Unit", typeof(Unit))]
	    public string UnitKey;

		public GetLastGoalUnit(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //long lastGoalUnitId = SceneHelper.Scene.GetComponent<GameStateComponent>().LastGoalUnitID;

	        //Unit unit = UnitHelper.GetUnit(lastGoalUnitId);
	        
	        //env.Add(this.UnitKey, unit);
	        return true;
        }
    }
}

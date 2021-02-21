namespace Model
{
   
	[Node(NodeClassifyType.Action, "获取最近玩家的进球数")]
	public class GetGoal : Node
	{
		[NodeOutput("系数", typeof(int))]
		public string GoalKey;
    
		public GetGoal(NodeProto nodeProto): base(nodeProto)
		{
		}

		protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
		{
			//int goalCount = SceneHelper.Scene.GetComponent<GameStateComponent>().GoalCount;
			//env.Add(this.GoalKey, goalCount);
			return true;
		}
	}
}
namespace Model
{
    [Node(NodeClassifyType.Action, "切换按键模式")]
    public class ChangeControlUIButton : Node
    {
	    [NodeInput("Team", typeof(int))]
	    public string TeamKey;

		public ChangeControlUIButton(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        int team = env.Get<int>(this.TeamKey);
			ChangeControl(team);
            return true;
        }

	    public static void ChangeControl(int team)
	    {
			//Game.EventSystem.Run(EventIdType.ChangeControl, team);
	    }
    }
}

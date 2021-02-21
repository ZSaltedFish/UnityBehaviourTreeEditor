namespace Model
{
    public enum GameState
    {
        UnStart,
        // 进入倒计时CountDown
        GameRunning,
        // 暂停
        Pause,
        Beginning,
        PauseEnd,
        // 重新设置Unit的位置
        UnitPosReset,
        // 开球
        BallStart,
    }

    [Node(NodeClassifyType.Action, "比较游戏状态")]
    public class CompareGameState : Node
    {
		[NodeField("状态机参数")]
	    public GameState State;

		public CompareGameState(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            return true;
        }
    }
}

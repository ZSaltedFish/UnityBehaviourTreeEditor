namespace Model
{
    public enum PauseType
    {
        /// <summary>
        /// 开场
        /// </summary>
        GameStart = 1,
        /// <summary>
        /// 进球
        /// </summary>
        Goal,
        /// <summary>
        /// 游戏结束
        /// </summary>
        GameOver,
    }

    [Node(NodeClassifyType.Condition, "判断死球原因（进球、开局）")]
    public class GetPauseReason : Node
    {
        [NodeField("死球原因")]
        public PauseType Reason;

        public GetPauseReason(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //if (GameStateComponent.Instance == null)
            //{
            //    return false;
            //}

            //return Reason == GameStateComponent.Instance.GamePauseType;
            return true;
        }
    }
}

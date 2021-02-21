namespace Model
{
    [Node(NodeClassifyType.Action)]
    public class PlayScoreChangeEffect : Node
    {
        [NodeField("特效时长")]
        public long WaitTime;
        [NodeField("删除时长")]
        public long DeleteAddTime;
        public PlayScoreChangeEffect(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //this.PlayScoreEffect(GameStateComponent.Instance.IsMyTeamGold);
            return true;
        }
    }
}

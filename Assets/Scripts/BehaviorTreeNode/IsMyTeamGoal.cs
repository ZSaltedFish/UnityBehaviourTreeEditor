namespace Model
{
    [Node(NodeClassifyType.Condition, "是否我方进球")]
    public class IsMyTeamGoal : Node
    {
        public IsMyTeamGoal(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //return GameStateComponent.Instance.IsMyTeamGold;
            return true;
        }
    }
}

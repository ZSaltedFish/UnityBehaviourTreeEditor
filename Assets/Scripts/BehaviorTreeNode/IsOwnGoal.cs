namespace Model
{
    [Node(NodeClassifyType.Condition, "是否是乌龙球")]
    public class IsOwnGoal : Node
    {
        public IsOwnGoal(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            
            //Unit unit = UnitHelper.GetUnit(GameStateComponent.Instance.LastGoalUnitID);
            //if (unit == null)
            //{
            //    return false;
            //}
            //else
            //{
            //    bool bMyTeamGoal = GameStateComponent.Instance.IsMyTeamGold;
            //    if (!bMyTeamGoal && (unit.Actor.Team == ActorHelper.MyActor().Team))
            //    {
            //        return true;//进球的人是已方，判断乌龙！
            //    }

            //    if (bMyTeamGoal && (unit.Actor.Team != ActorHelper.MyActor().Team))
            //    {
            //        return true;//进球的人是对方，又是对方进球，判断乌龙！
            //    }
            //}
            
            return false;
        }
    }
}

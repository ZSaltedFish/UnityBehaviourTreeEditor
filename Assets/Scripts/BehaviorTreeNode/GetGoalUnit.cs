namespace Model
{
    [Node(NodeClassifyType.DataTransform, "获取进球单位")]
    public class GetGoalUnit : Node
    {
        [NodeOutput("获取进球单位", typeof(Unit))]
        public string GoalUnit;

        public GetGoalUnit(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit unit = UnitHelper.GetUnit(GameStateComponent.Instance.LastGoalUnitID);
            //if (unit == null)
            //{
            //    return false;
            //}
            //env.Add(GoalUnit, unit);
            return true;
        }
    }
}

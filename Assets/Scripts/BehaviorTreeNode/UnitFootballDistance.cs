namespace Model
{
    [Node(NodeClassifyType.Condition, "球员与足球合理距离判断")]
    public class UnitFootballDistance : Node
    {
        [NodeInput("UnitName", typeof(Unit))]
        public string UnitName;
        public UnitFootballDistance(NodeProto nodeProto): base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit unit = env.Get<Unit>(UnitName);
            //return FootBallHelper.IsOnSize(unit);
            return true;
        }
    }
}

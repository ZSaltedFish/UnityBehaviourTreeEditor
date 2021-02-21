namespace Model
{
    [Node(NodeClassifyType.Condition, "判断单位是不是队友")]
    public class IsTeamMate : Node
    {
        [NodeInput("判断的单位", typeof(Unit))]
        public string InputUnit;

        public IsTeamMate(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit unit = env.Get<Unit>(InputUnit);
            //return UnitHelper.IsTeamMate(unit);
            return true;
        }
    }
}

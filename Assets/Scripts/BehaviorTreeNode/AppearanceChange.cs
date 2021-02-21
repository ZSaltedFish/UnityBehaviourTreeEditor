namespace Model
{
    [Node(NodeClassifyType.Action, "换装")]
    public class AppearanceChange : Node
    {
        [NodeField("装束名字")]
        public string AppearanceName;
        [NodeInput("目标", typeof(Unit))]
        public string UnitName;
        public AppearanceChange(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit unit = env.Get<Unit>(UnitName);
            //unit.GetComponent<UnitAppearanceComponent>().ApplyAppearance(AppearanceName);
            return true;
        }
    }
}

namespace Model
{
    [Node(NodeClassifyType.Action, "获取所有Players")]
    public class GetAllPlayers : Node
    {
        [NodeOutput("Players", typeof(Unit[]))]
        public string PlayersKey;

        public GetAllPlayers(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit[] units = UnitComponent.Instance.GetUnits(UnitType.Player);
            //env.Add(this.PlayersKey, units);
            return true;
        }
    }
}

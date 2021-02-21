namespace Model
{
    [Node(NodeClassifyType.DataTransform, "通过球员获取对应玩家的VIP等级")]
    public class UnitActorVIP : Node
    {
        [NodeInput("对应球员", typeof(Unit))]
        public string UnitName;
        [NodeOutput("球员VIP等级(0, 1, 10, 11)", typeof(int))]
        public string VIPName;
        public UnitActorVIP(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit unit = env.Get<Unit>(UnitName);
            //Actor actor = unit.Actor;
            //int vip = actor.VIP;
            //env.Add(VIPName, vip);
            return true;
        }
    }
}

namespace Model
{
    [Node(NodeClassifyType.Action, "获取buff的所有者")]
    public class GetBuffOwner : Node
    {
        [NodeInput("Buff", typeof(Buff))]
        public string BuffKey;

        [NodeOutput("buff所有者", typeof(Unit))]
        public string UnitKey;

        public GetBuffOwner(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
   //         Buff buff = env.Get<Buff>(BuffKey);
			//env.Add(this.UnitKey, buff.Target);
            return true;
        }
    }
}

namespace Model
{
    [Node(NodeClassifyType.DataTransform, "获取Buff的目标")]
    public class GetBuffTarget : Node
    {
        [NodeInput("Buff", typeof(Buff))]
        public string BuffName;
        [NodeOutput("Buff 目标", typeof(Unit))]
        public string BuffTarget;

        public GetBuffTarget(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            Buff buff = env.Get<Buff>(BuffName);
            //env.Add(BuffTarget, buff.Target);
            return true;
        }
    }
}

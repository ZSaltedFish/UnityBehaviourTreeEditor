namespace Model
{
    [Node(NodeClassifyType.Action, "设置目标为空")]
    public class SetTargetNull : Node
    {
		[NodeInput("设置unit", typeof(Unit))]
		public string SourceUnit;

		public SetTargetNull(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit sourceUnit = env.Get<Unit>(this.SourceUnit);
	        //sourceUnit.GetComponent<TargetComponent>().SelectTargetType = SelectTargetType.None;
	        return true;
        }
    }
}

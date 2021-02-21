namespace Model
{
    [Node(NodeClassifyType.Action, "Unit是否为空")]
    public class UnitIsNull : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string Unit;

		public UnitIsNull(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        Unit unit = env.Get<Unit>(this.Unit);
	        return unit == null;
        }
    }
}

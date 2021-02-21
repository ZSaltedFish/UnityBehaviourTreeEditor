namespace Model
{
    [Node(NodeClassifyType.Condition, "是否是控制的Unit")]
    public class IsControlled : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

		public IsControlled(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit a = env.Get<Unit>(this.UnitKey);

	        //bool result = a.Actor.ControlUnit.Id == a.Id;
	        return true;
        }
    }
}

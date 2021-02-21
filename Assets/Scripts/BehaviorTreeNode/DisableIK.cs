namespace Model
{
    [Node(NodeClassifyType.Action, "是否启用IK")]
    public class DisableIK : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

		public DisableIK(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            return true;
        }
    }
}

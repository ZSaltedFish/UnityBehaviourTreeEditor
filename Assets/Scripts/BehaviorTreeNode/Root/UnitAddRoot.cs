namespace Model
{
	[Node(NodeClassifyType.Root, "Unit Add Root")]
	public class UnitAddRoot : Node
	{
		[NodeOutput("Unit", typeof(Unit), BTEnvKey.Unit)]
		private string unitKey = BTEnvKey.Unit;

		public UnitAddRoot(NodeProto nodeProto): base(nodeProto)
		{
		}

		protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
		{
			foreach (Node node in this.children)
			{
				node.DoRun(behaviorTree, env);
			}
			return true;
		}
	}
}

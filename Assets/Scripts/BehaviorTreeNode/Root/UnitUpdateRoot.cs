namespace Model
{
	[Node(NodeClassifyType.Root, "Unit Update Root")]
	public class UnitUpdateRoot : Node
	{
		[NodeOutput("Unit", typeof(Unit), BTEnvKey.Owner)]
		private string unitKey = BTEnvKey.Owner;

		public UnitUpdateRoot(NodeProto nodeProto): base(nodeProto)
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

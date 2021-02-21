namespace Model
{
	[Node(NodeClassifyType.Root, "Unit Remove Root")]
	public class UnitRemoveRoot : Node
	{
		[NodeOutput("Unit", typeof(Unit), BTEnvKey.Unit)]
		private string unitKey = BTEnvKey.Unit;

		public UnitRemoveRoot(NodeProto nodeProto): base(nodeProto)
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

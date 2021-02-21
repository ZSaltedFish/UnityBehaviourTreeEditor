namespace Model
{
	[Node(NodeClassifyType.Root, "Buff Update Root")]
	public class BuffUpdateRoot : Node
	{
		[NodeOutput("Buff", typeof(Buff), BTEnvKey.Owner)]
		private string buffKey = BTEnvKey.Owner;

		public BuffUpdateRoot(NodeProto nodeProto): base(nodeProto)
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

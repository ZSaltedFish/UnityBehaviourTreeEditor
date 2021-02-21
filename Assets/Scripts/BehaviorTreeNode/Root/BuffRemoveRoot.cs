namespace Model
{
	[Node(NodeClassifyType.Root, "Buff Remove Root")]
	public class BuffRemoveRoot : Node
	{
		[NodeOutput("Buff", typeof(Buff), BTEnvKey.Buff)]
		private string buffKey = BTEnvKey.Buff;

		public BuffRemoveRoot(NodeProto nodeProto): base(nodeProto)
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

namespace Model
{
	[Node(NodeClassifyType.Decorator)]
	public class False : Node
	{
		public False(NodeProto nodeProto): base(nodeProto)
		{
		}

		protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
		{
			foreach (Node child in children)
			{
				child.DoRun(behaviorTree, env);
			}
			return false;
		}
	}
}
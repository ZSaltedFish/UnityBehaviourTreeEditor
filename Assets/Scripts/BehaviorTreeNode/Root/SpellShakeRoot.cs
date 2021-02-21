namespace Model
{
	[Node(NodeClassifyType.Root, "技能前摇Root")]
	public class SpellShakeRoot : Node
	{
		[NodeOutput("技能", typeof(Spell), BTEnvKey.Spell)]
		private string spellKey = BTEnvKey.Spell;

		public SpellShakeRoot(NodeProto nodeProto): base(nodeProto)
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

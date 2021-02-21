namespace Model
{
	[Node(NodeClassifyType.Root, "技の効果発動のタイミング")]
	public class SpellHitRoot : Node
	{
		[NodeOutput("技", typeof(Spell), BTEnvKey.Spell)]
		public string spellKey = BTEnvKey.Spell;

		public SpellHitRoot(NodeProto nodeProto): base(nodeProto)
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

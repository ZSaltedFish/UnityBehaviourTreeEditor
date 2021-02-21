namespace Model
{
    [Node(NodeClassifyType.Action, "获取技能的施放者")]
    public class GetSpellCaster : Node
    {
        [NodeInput("Spell", typeof(Spell))]
        public string SpellKey;

        [NodeOutput("Spell Caster", typeof(Unit))]
        public string UnitKey;

        public GetSpellCaster(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
   //         Spell spell = env.Get<Spell>(this.SpellKey);
			//env.Add(this.UnitKey, spell.Caster);
            return true;
        }
    }
}

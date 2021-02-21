namespace Model
{
    [Node(NodeClassifyType.Action, "是否在施放技能")]
    public class IsInSpell : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

		public IsInSpell(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit unit = env.Get<Unit>(this.UnitKey);

            //return unit.GetComponent<SpellComponent>().Spell != null;
            return true;
        }
    }
}

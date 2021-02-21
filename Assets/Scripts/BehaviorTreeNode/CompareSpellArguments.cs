namespace Model
{
    [Node(NodeClassifyType.Composite, "技能参数值的比较")]
    public class CompareSpellArguments : Node
    {
        [NodeInput("Spell", typeof(Spell))]
        public string SpellKey;
        [NodeField("比较符")]
        public Operator Operator;
        [NodeField("技能KEY")]
        public string SpellArgumentKey;

        [NodeField("比较值")]
        public int Value;

        public CompareSpellArguments(NodeProto nodeProto): base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //    Spell spell = env.Get<Spell>(this.SpellKey);
            //    SpellNumericComponent snc = spell.GetComponent<SpellNumericComponent>();
            //    bool result = false;
            //    if (snc != null)
            //    {
            //        int spellArgsVal = snc[SpellArgumentKey];
            //        switch (Operator)
            //        {
            //            case Operator.EQ:
            //                result = spellArgsVal == this.Value;
            //                break;
            //            case Operator.GE:
            //                result = spellArgsVal >= this.Value;
            //                break;
            //            case Operator.GT:
            //                result = spellArgsVal > this.Value;
            //                break;
            //            case Operator.LE:
            //                result = spellArgsVal <= this.Value;
            //                break;
            //            case Operator.LT:
            //                result = spellArgsVal < this.Value;
            //                break;
            //        }
            //    }

            //    if (result)
            //    {
            //        foreach (Node child in this.children)
            //        {
            //            child.DoRun(behaviorTree, env);
            //        }
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            return true;
        }
    }
}

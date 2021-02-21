using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "创建Spell特效")]
    public class CreateSpellEffect : Node
    {
        [NodeField("创建特效")]
        public GameObject[] Effects;
        
        [NodeInput("Unit", typeof(Unit))]
        public string Unit;

        [NodeInput("Spell", typeof(Spell))]
        public string SpellKey;

        public CreateSpellEffect(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Spell spell = env.Get<Spell>(this.SpellKey);
            
            //Unit unit = env.Get<Unit>(this.Unit);
            
            //foreach (GameObject go in Effects)
            //{
            //    Unit effect = EffectFactory.Create(go, unit, false);
            //    spell.Effects.Add(effect.Id);
            //}
            return true;
        }
    }
}

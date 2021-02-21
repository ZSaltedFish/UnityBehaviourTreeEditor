using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "创建足球阴影")]
    public class CreateFootballShadow : Node
    {
        [NodeField("创建特效")]
        public GameObject[] Effects;

        [NodeInput("Unit", typeof(Unit))]
        public string UnitKey;

        public CreateFootballShadow(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit unit = env.Get<Unit>(this.UnitKey);
            //foreach (GameObject go in Effects)
            //{
            //    Unit effectUnit = EffectFactory.Create(go, unit.Position, unit.Rotation);
            //    effectUnit.AddComponent<FootballShadowComponent, Unit>(unit);
            //}
            return true;
        }
    }
}

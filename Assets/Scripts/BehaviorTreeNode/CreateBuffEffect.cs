using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "创建Buff特效")]
    public class CreateBuffEffect : Node
    {
        [NodeField("创建特效")]
        public GameObject[] Effects;

        [NodeInput("Buff", typeof(Buff))]
        public string BuffKey;

        public CreateBuffEffect(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Buff buff = env.Get<Buff>(BuffKey);
            //foreach (GameObject go in Effects)
            //{
            //    Unit effect = EffectFactory.Create(go, buff.Target, false);
            //    buff.Effects.Add(effect);
            //}
            return true;
        }
    }
}

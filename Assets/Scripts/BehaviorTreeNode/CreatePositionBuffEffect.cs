using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "创建球员位置的Buff特效")]
    public class CreatePositionBuffEffect : Node
    {
        [NodeField("创建特效")]
        public GameObject[] Effects;

        [NodeInput("Buff", typeof(Buff))]
        public string BuffKey;

        public CreatePositionBuffEffect(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Buff buff = env.Get<Buff>(BuffKey);
            //foreach (GameObject go in Effects)
            //{
            //    CreateEffectUnit(go,buff.Target,buff);
            //}

            return true;
        }
    }
}

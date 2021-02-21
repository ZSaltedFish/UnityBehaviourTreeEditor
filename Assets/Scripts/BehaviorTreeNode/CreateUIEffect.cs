using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "播放UI特效")]
    public class CreateUIEffect : Node
    {
        [NodeField("特效组")]
        public GameObject[] Effects;

        public CreateUIEffect(NodeProto p)
            : base(p)
        {

        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            foreach (GameObject goes in Effects)
            {
                //EffectFactory.CreateUIEffect(goes);
            }
            return true;
        }
    }
}

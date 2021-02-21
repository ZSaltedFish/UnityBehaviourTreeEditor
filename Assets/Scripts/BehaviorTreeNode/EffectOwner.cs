using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "特效指定点")]
    public class EffectOwner : Node
    {
        [NodeInput("特效", typeof(Unit))]
        public string Effect;
        
        [NodeOutput("特效主人", typeof(Unit))]
        public string Owner;

        public EffectOwner(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit effect = env.Get<Unit>(Effect);
            //Unit owner = effect.GetComponent<EffectComponent>().Owner;
            //env.Add(this.Owner, owner);
            return true;
        }
    }
}

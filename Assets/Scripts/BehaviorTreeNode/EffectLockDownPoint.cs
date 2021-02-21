using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "特效指定点")]
    public class EffectLockDownPoint : Node
    {
        [NodeInput("特效", typeof(Unit))]
        public string Effect;
        [NodeInput("特效 目标", typeof(Unit))]
        public string Target;

        public EffectLockDownPoint(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit target = env.Get<Unit>(Target);
            //Unit effect = env.Get<Unit>(Effect);
            //Vector3 p = target.GetComponent<BindPointComponent>()[effect.GetConfig<EffectMonoConfig>().BindType];

            //LineRenderer[] renderers = effect.GameObject.GetComponentsInChildren<LineRenderer>();
            //foreach (var item in renderers)
            //{
            //    float dist = Vector3.Distance(p, item.transform.position);
            //    item.transform.LookAt(p);
            //    item.SetPosition(0, new Vector3(0, 0, dist));
            //}
            return true;
        }
    }
}

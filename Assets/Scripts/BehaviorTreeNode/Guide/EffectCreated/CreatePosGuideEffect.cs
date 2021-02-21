using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "在固定位置创建一个新手引导的特效")]
    public class CreatePosGuideEffect : Node
    {
        [NodeField("名字索引")]
        public string Name;
        [NodeField("特效")]
        public GameObject EffectRes;
        [NodeInput("创建位置", typeof(Vector3))]
        public string InputVector;

        public CreatePosGuideEffect(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit unit = EffectFactory.Create(EffectRes, false);
            //GuideComponent.Instance.AddEffect(Name, unit);
            //unit.Position = env.Get<Vector3>(InputVector);
            return true;
        }
    }
}

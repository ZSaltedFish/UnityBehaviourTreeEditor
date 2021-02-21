using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "创建一个特效到单位上")]
    public class CreateUnitGuideEffect : Node
    {
        [NodeField("名字索引")]
        public string Name;
        [NodeField("特效")]
        public GameObject EffectRes;
        [NodeInput("单位", typeof(Unit))]
        public string SrcUnit;

        public CreateUnitGuideEffect(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit srcUnit = env.Get<Unit>(SrcUnit);
            //Unit unit = EffectFactory.Create(EffectRes, srcUnit, false);
            //GuideComponent.Instance.AddEffect(Name, unit);
            return true;
        }
    }
}

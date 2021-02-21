using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "替换材质球")]
    public class ReplaceMaterial : Node
    {
        [NodeField("渲染器索引，-1为所有渲染器", -1)]
        public int RendererIndex;
        [NodeField("材质球数组")]
        public Material[] Materials;
        [NodeInput("需求BUFF", typeof(Buff))]
        public string SrcBuff;

        public ReplaceMaterial(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Buff buff = env.Get<Buff>(SrcBuff);
            //Unit targetUnit = buff.Target;
            //UnitMaterialComponent matComp = targetUnit.GetComponent<UnitMaterialComponent>();

            //matComp.ChangeMaterial(RendererIndex, buff.Id, Materials);
            return true;
        }
    }
}

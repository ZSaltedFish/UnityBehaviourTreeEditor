using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "替换材质球不需要buff")]
    public class ReplaceMaterialWithoutBuff : Node
    {
		[NodeInput("unit", typeof(Unit))]
	    public string UnitKey;
        [NodeField("渲染器索引，-1为所有渲染器", -1)]
        public int RendererIndex;
        [NodeField("材质球数组")]
        public Material[] Materials;

        public ReplaceMaterialWithoutBuff(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit targetUnit = env.Get<Unit>(this.UnitKey);
         //   UnitMaterialComponent matComp = targetUnit.GetComponent<UnitMaterialComponent>();

         //   matComp.ChangeMaterial(RendererIndex, targetUnit.Id, Materials);
            return true;
        }
    }
}

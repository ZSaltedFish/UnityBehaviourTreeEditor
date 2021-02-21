using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "设置场景上单位的Alpha值")]
    public class SetUnitAlpha : Node
    {
        [NodeInput("单位", typeof(Unit))]
        public string UnitName;
        [NodeField("Alpha Value", 1)]
        public float AlphaValue;

        public SetUnitAlpha(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit unit = env.Get<Unit>(UnitName);
            //UnitMaterialComponent matComp = unit.GetComponent<UnitMaterialComponent>();
            //if (matComp != null)
            //{
            //    Log.Error("不可以在非场上静态物品上使用该节点");
            //    return true;
            //}

            //Renderer[] renderers = unit.GameObject.GetComponentsInChildren<Renderer>();
            //foreach (Renderer renderer in renderers)
            //{
            //    Material mat = renderer.sharedMaterial;
            //    Color color = mat.color;
            //    color.a = AlphaValue;
            //    mat.color = color;
            //}
            return true;
        }
    }
}

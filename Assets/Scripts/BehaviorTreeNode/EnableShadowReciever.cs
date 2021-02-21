using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "获取主摄像机")]
    public class EnableShadowReciever : Node
    {
		[NodeField("是否开启")]
	    public bool Enable;

        public EnableShadowReciever(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {

            //if (QualityComponent.Instance.GetShadowEnable())
            //{
            //    GameObject shadow = SceneHelper.Scene.GetComponent<SceneConfigComponent>().Config.Get<GameObject>("Shadow");
            //    shadow.SetActive(this.Enable);
            //}
            return true;
        }
    }
}

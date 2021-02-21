using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "获取主摄像机父")]
    public class GetMainCameraParent : Node
    {
        [NodeOutput("CameraParent", typeof (GameObject))]
        public string CameraKey;

        public GetMainCameraParent(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //GameObject mainCamera = CameraMotorComponent.Instance.Camera.gameObject;
            //if(mainCamera != null)
            //{
            //    env.Add(this.CameraKey, mainCamera.transform.parent.gameObject);
            //}
            return true;
        }
    }
}

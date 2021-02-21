using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "获取主摄像机")]
    public class GetMainCamera : Node
    {
        [NodeOutput("Camera", typeof (GameObject))]
        public string CameraKey;

        public GetMainCamera(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //GameObject mainCamera = CameraMotorComponent.Instance.Camera.gameObject;
            //env.Add(this.CameraKey, mainCamera);
            return true;
        }
    }
}

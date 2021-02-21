namespace Model
{
    public enum CameraState
    {
        None,
        Low,
        High,
        Victory,
        Shoot,
    }

    [Node(NodeClassifyType.Action, "设置摄像机旋转")]
    public class SetCameraRotation : Node
    {
        [NodeField("相机状态")]
        public CameraState CamState;
        
		public SetCameraRotation(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //if (CameraMotorComponent.Instance != null)
            //{
            //    CameraMotorComponent.Instance.State = CamState;
            //}
            
            return true;
        }
    }
}

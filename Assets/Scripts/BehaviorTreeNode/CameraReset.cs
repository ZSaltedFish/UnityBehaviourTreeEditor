namespace Model
{
    [Node(NodeClassifyType.Action, "重置摄像机")]
    public class CameraReset : Node
    {
        [NodeField("是否重置位置")]
        public bool ResetPosition;

        [NodeField("是否重置角度")]
        public bool ResetRotation;
        
		public CameraReset(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //if (this.ResetPosition)
            //{
            //    CameraMotorComponent.Instance.ResetCameraPosition();
            //}
            //if (this.ResetRotation)
            //{
            //    CameraMotorComponent.Instance.ResetCameraRotation();
            //}
            return true;
        }
    }
}

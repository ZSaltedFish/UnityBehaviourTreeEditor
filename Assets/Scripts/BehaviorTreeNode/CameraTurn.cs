namespace Model
{
    [Node(NodeClassifyType.Action, "旋转摄像机rotation")]
    public class CameraTurn : Node
    {
		public CameraTurn(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //CameraMotorComponent.Instance.UpdateRotation();
            return true;
        }
    }
}

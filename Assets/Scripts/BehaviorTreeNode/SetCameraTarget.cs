namespace Model
{
    [Node(NodeClassifyType.Action, "设置摄像机目标")]
    public class SetCameraTarget : Node
    {
	    [NodeInput("目标unit", typeof(Unit))]
		public string TargetUnit;

		public SetCameraTarget(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	  //      Unit targetUnit = env.Get<Unit>(this.TargetUnit);
			//CameraMotorComponent.Instance?.SetTarget(targetUnit);
	        return true;
        }
    }
}

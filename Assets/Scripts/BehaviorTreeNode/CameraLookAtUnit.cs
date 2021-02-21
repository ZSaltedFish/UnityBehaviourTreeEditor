namespace Model
{
	[Node(NodeClassifyType.Action, "摄像机盯住Unit")]
	public class CameraLookAtUnit: Node
	{
		[NodeInput("Unit", typeof(Unit))]
		public string Unit;
    
		public CameraLookAtUnit(NodeProto nodeProto): base(nodeProto)
		{
		}

		protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
		{
			//Unit unit = env.Get<Unit>(this.Unit);
			//CameraMotorComponent.Instance.LookAt(unit.Position);
			return true;
		}
	}
}
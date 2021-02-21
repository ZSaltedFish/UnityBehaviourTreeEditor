namespace Model
{
   
	[Node(NodeClassifyType.Action, "摄像机抖动")]
	public class CameraShake: Node
	{
		[NodeField("抖动时间 毫秒")]
		public long ShakeTime;

		[NodeField("振幅")]
		public float Amp;
		
		[NodeField("系数")]
		public float Factor;
    
		public CameraShake(NodeProto nodeProto): base(nodeProto)
		{
		}

		protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
		{
			//SceneHelper.Scene.GetComponent<CameraComponent>().Unit
			//		.GetComponent<CameraShakeComponent>()
			//		.Shake(this.ShakeTime / 1000f, this.Amp, this.Factor);
			return true;
		}
	}
}
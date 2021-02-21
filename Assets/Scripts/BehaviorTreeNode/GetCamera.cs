namespace Model
{
    [Node(NodeClassifyType.Action, "获取CameraUnit")]
    public class GetCamera : Node
    {
	    [NodeOutput("获取Camera", typeof(Unit))]
		public string Camera;

		public GetCamera(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit camera = CameraComponent.Instance.Unit;
	        //env.Add(this.Camera, camera);
	        return true;
        }
    }
}

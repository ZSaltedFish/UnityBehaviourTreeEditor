namespace Model
{
    [Node(NodeClassifyType.Condition, "获取射门按键时间")]
    public class GetShootTime : Node
    {
		[NodeOutput("ShootTime", typeof(float))]
	    public string ShootTime;

		public GetShootTime(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //if (ControlDataComponent.Instance == null)
	        //{
		       // return false;
	        //}
	        //float shootTime = ControlDataComponent.Instance.ShootTime;
	        //env.Add(this.ShootTime, shootTime);
			return true;
        }
    }
}

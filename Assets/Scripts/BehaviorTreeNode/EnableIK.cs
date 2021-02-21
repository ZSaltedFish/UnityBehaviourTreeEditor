namespace Model
{
    [Node(NodeClassifyType.Action, "是否启用IK")]
    public class EnableIK : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;
	    
	    [NodeInput("Target", typeof(Unit))]
	    public string TargetKey;
  
	    [NodeField("左手")]
	    public bool LeftHand;
	    [NodeField("左手权重")]
	    public float LeftHandValue;
	    
	    [NodeField("右手")]
	    public bool RightHand;
	    [NodeField("右手权重")]
	    public float RightHandValue;
	    
	    [NodeField("左脚")]
	    public bool LeftFoot;
	    [NodeField("左脚权重")]
	    public float LeftFootValue;
	    
	    [NodeField("右脚")]
	    public bool RightFoot;
	    [NodeField("右脚权重")]
	    public float RightFootValue;

		public EnableIK(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //return true;
	        //Unit unit = env.Get<Unit>(this.UnitKey);
	        //Unit target = env.Get<Unit>(this.TargetKey);
	        //IKController ikController = unit.GameObject.GetComponent<IKController>();
	        //ikController.Transform = target.GameObject.transform;
	        
	        //ikController.LeftFoot = this.LeftFoot;
	        //ikController.LeftFootValue = this.LeftFootValue;
	        //ikController.LeftHand = this.LeftHand;
	        //ikController.LeftHandValue = this.LeftHandValue;
	        //ikController.RightFoot = this.RightFoot;
	        //ikController.RightFootValue = this.RightFootValue;
	        //ikController.RightHand = this.RightHand;
	        //ikController.RightHandValue = this.RightHandValue;

	        return true;
        }
    }
}

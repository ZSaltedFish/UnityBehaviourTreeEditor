namespace Model
{
    [Node(NodeClassifyType.Action, "移动停止")]
    public class RunStop : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

        public RunStop(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = env.Get<Unit>(this.UnitKey);
	        //unit.GetComponent<MotorComponent>().Stop();
	        return true;
        }
    }
}

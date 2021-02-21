namespace Model
{
    [Node(NodeClassifyType.Action, "移动中是否到达指定的目标点")]
    public class IsArrived : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

        public IsArrived(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit unit = env.Get<Unit>(this.UnitKey);
            //return unit.GetComponent<MotorComponent>().IsArrived;
            return true;
        }
    }
}

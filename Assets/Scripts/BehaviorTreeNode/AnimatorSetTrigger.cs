namespace Model
{
    [Node(NodeClassifyType.Action, "修改状态机参数")]
    public class AnimatorSetTrigger : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

		[NodeField("Animator Param")]
	    public string Name;

		public AnimatorSetTrigger(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	  //      Unit unit = env.Get<Unit>(this.UnitKey);
			//unit.GetComponent<AnimatorComponent>().SetTrigger(this.Name);

	        return true;
        }
    }
}

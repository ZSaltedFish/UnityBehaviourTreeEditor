namespace Model
{
    [Node(NodeClassifyType.Condition, "RandomAnimator")]
    public class RandomAnimator : Node
    {
	    [NodeInput("UnitKey", typeof(Unit))]
	    public string UnitKey;

		public RandomAnimator(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = env.Get<Unit>(this.UnitKey);
	        //AnimatorComponent animatorComponent = unit.GetComponent<AnimatorComponent>();
	        //int random = RandomHelper.RandomNumber(0, 10000);
	        //animatorComponent.SetIntValue("Random", random);
			return true;
        }
    }
}

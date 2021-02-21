namespace Model
{
    [Node(NodeClassifyType.Condition, "比较float值")]
    public class CompareFloat : Node
    {
	    [NodeInput("数值", typeof(float))]
	    public string AKey;

	    [NodeField("比较符")]
		public Operator Operator;

	    [NodeField("比较值")]
	    public float Value;

		public CompareFloat(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        float a = env.Get<float>(this.AKey);
	        switch (Operator)
	        {
				case Operator.EQ:
					return a == this.Value;
				case Operator.GE:
					return a >= this.Value;
				case Operator.GT:
					return a > this.Value;
				case Operator.LE:
					return a <= this.Value;
				case Operator.LT:
					return a < this.Value;
	        }
	        return true;
        }
    }
}

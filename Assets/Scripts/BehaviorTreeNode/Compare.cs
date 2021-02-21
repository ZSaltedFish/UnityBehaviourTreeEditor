namespace Model
{
	public enum Operator
	{
		GT,
		GE,
		LT,
		LE,
		EQ,
	}

    [Node(NodeClassifyType.Condition, "比较int值")]
    public class Compare : Node
    {
	    [NodeInput("数值", typeof(int))]
	    public string AKey;

	    [NodeField("比较符")]
		public Operator Operator;

	    [NodeField("比较值")]
	    public int Value;

		public Compare(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        int a = env.Get<int>(this.AKey);
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

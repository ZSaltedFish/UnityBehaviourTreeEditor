namespace Model
{
    [Node(NodeClassifyType.Composite, "比较int值")]
    public class CompareValue : Node
    {
	    [NodeInput("数值", typeof(int))]
	    public string AKey;

	    [NodeField("比较符")]
		public Operator Operator;

	    [NodeField("比较值")]
	    public int Value;

		public CompareValue(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        int a = env.Get<int>(this.AKey);
            bool result = false;
	        switch (Operator)
	        {
				case Operator.EQ:
                    result = a == this.Value;
                    break;
				case Operator.GE:
                    result = a >= this.Value;
                    break;
				case Operator.GT:
                    result = a > this.Value;
                    break;
				case Operator.LE:
                    result = a <= this.Value;
                    break;
				case Operator.LT:
                    result = a < this.Value;
                    break;
	        }
            
            if (result)
            {
                foreach (Node child in this.children)
                {
                    child.DoRun(behaviorTree, env);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

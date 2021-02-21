namespace Model
{
    [Node(NodeClassifyType.Condition, "Multiply float")]
    public class MultiplyFloat : Node
    {
	    [NodeField("Value")]
	    public float Value;
	    
	    [NodeInput("Input", typeof(float))]
	    public string Input;
	    
		[NodeOutput("Output", typeof(float))]
	    public string Output;

		public MultiplyFloat(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        float input = env.Get<float>(this.Input);
	        float output = this.Value * input;
	        env.Add(this.Output, output);
			return true;
        }
    }
}

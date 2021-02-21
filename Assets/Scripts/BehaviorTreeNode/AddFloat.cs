namespace Model
{
    [Node(NodeClassifyType.Condition, "add float")]
    public class AddFloat : Node
    {
	    [NodeInput("Input", typeof(float))]
	    public string Input;
	    
	    [NodeField("Value")]
	    public float Value;
	    
		[NodeOutput("Output", typeof(float))]
	    public string Output;

		public AddFloat(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        float input = env.Get<float>(this.Input);
	        float output = input + this.Value;
	        env.Add(this.Output, output);
			return true;
        }
    }
}

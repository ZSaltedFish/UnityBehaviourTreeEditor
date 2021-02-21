namespace Model
{
    [Node(NodeClassifyType.Condition, "输出一个Int值")]
    public class IntValue : Node
    {
	    [NodeField("int")]
	    public int Value;

	    [NodeOutput("intKey", typeof(int))]
		public string IntKey;

		public IntValue(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        env.Add(this.IntKey, this.Value);
	        return true;
        }
    }
}

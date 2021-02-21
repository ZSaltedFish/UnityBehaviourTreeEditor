namespace Model
{
    [Node(NodeClassifyType.Condition, "输出一个Float值")]
    public class FloatValue : Node
    {
	    [NodeField("Float")]
	    public float Value;

	    [NodeOutput("FloatKey", typeof(float))]
		public string FloatKey;

		public FloatValue(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        env.Add(this.FloatKey, this.Value);
	        return true;
        }
    }
}

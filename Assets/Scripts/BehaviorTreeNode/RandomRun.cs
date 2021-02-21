namespace Model
{
    [Node(NodeClassifyType.Composite, "RandomRun")]
    public class RandomRun : Node
    {
	    [NodeField("Value 0-9999")]
	    public int Value;

		public RandomRun(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	  //      int random = RandomHelper.RandomNumber(0, 10000);
	  //      if (random > this.Value)
	  //      {
		 //       return false;
	  //      }

			//foreach (Node child in this.children)
			//{
			//	child.DoRun(behaviorTree, env);
			//}
			return true;
        }
    }
}

namespace Model
{
    [Node(NodeClassifyType.Decorator, "RunEveryNFrame")]
    public class RunEveryNFrame : Node
    {
	    [NodeField("N")]
	    public int N;

		public RunEveryNFrame(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //if (Game.Time.FrameCount % this.N != 0)
	        //{
		       // return false;
	        //}

	        //foreach (Node child in this.children)
	        //{
		       // child.DoRun(behaviorTree, env);
	        //}
	        
			return true;
        }
    }
}

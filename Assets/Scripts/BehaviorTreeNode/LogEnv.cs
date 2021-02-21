namespace Model
{
    [Node(NodeClassifyType.Condition, "输出evn中的值")]
    public class LogEnv : Node
    {
	    [NodeField("打印的值")]
	    public string Key;

		public LogEnv(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	  //      object a = env.Get<object>(this.Key);
			//Log.Debug($"env : {JsonHelper.ToJson(a)}");
	        return true;
        }
    }
}

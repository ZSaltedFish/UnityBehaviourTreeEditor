using System;

namespace Model
{
    [Node(NodeClassifyType.Composite, "延迟一定时间执行")]
    public class DelayInInput : Node
    {
	    [NodeInput("延迟时间单位毫秒",typeof(int))]
	    public string ms;

		public DelayInInput(NodeProto nodeProto): base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
			//this.DelayRun(behaviorTree, env);
			return true;
        }
    }
}

using System;

namespace Model
{
    [Node(NodeClassifyType.Composite, "延迟执行")]
    public class Delay : Node
    {
	    [NodeField("延迟时间单位毫秒")]
	    public int ms;

		public Delay(NodeProto nodeProto): base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
			//this.DelayRun(behaviorTree, env);
			return true;
        }
    }
}

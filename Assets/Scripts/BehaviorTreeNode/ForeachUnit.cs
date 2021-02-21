using System.Collections.Generic;

namespace Model
{
    [Node(NodeClassifyType.Composite, "对每个Unit执行子节点")]
    public class ForeachUnit : Node
    {
        [NodeInput("Unit集合", typeof(List<Unit>))]
        public string UnitListKey;

	    [NodeInput("单个Unit", typeof(Unit))]
	    public string UnitKey;

		public ForeachUnit(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        List<Unit> list = env.Get<List<Unit>>(this.UnitListKey);
	        foreach (Unit unit in list)
	        {
		        env.Add(this.UnitKey, unit);

		        foreach (Node child in this.children)
		        {
			        child.DoRun(behaviorTree, env);
		        }
	        }
            return true;
        }
    }
}

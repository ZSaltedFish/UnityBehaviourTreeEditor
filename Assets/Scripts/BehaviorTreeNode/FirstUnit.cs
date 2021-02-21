using System.Collections.Generic;
using System.Linq;

namespace Model
{
    [Node(NodeClassifyType.Action, "取第一个Unit")]
    public class FirstUnit : Node
    {
        [NodeInput("Units", typeof(List<Unit>))]
        public string Units;
		
	    [NodeOutput("Unit", typeof(Unit))]
	    public string Unit;

		public FirstUnit(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        List<Unit> list = env.Get<List<Unit>>(this.Units);
	        env.Add(this.Unit, list.FirstOrDefault());
	        return true;
        }
    }
}

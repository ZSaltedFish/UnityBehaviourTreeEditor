using System.Collections.Generic;

namespace Model
{
    [Node(NodeClassifyType.Condition, "add float")]
    public class SaveCeleEffect : Node
    {
	    [NodeInput("Unit", typeof(List<Unit>))]
	    public string UnitKey;

		public SaveCeleEffect(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //List<Unit> unit = env.Get<List<Unit>>(this.UnitKey);
	        //UnitComponent.Instance.CeleEffectId = unit[0].Id;
			return true;
        }
    }
}

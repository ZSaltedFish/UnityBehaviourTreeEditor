using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "Unit加Buff")]
    public class CreateBuff : Node
    {
        [NodeField("Buff")]
        public GameObject BuffConfig;

	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

        public CreateBuff(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = env.Get<Unit>(UnitKey);
	        //BuffFactory.Create(unit, BuffConfig);
            return true;
        }
    }
}

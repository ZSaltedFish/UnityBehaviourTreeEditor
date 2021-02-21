using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "是否开启Turn")]
    public class EnableTurn : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

	    [NodeField("Value", typeof(bool))]
	    public bool Value;

		public EnableTurn(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	   //     Unit unit = env.Get<Unit>(this.UnitKey);

	   //     MotorComponent motorComponent = unit.GetComponent<MotorComponent>();

	   //     if (this.Value)
	   //     {
				//motorComponent.ApplySaveTurn();
	   //     }
	   //     else
	   //     {
		  //      motorComponent.SaveTurn();
	   //     }

	        return true;
        }
    }
}

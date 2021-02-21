using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "获取目标Unit")]
    public class GetTargetUnit : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

	    [NodeOutput("位置", typeof(Unit))]
		public string TargetKey;

		public GetTargetUnit(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	   //     Unit unit = GetUnit(env);
	   //     Unit target = unit.GetComponent<TargetComponent>().Target;
	   //     if (target == null)
	   //     {
				//return false;
	   //     }
	   //     env.Add(this.TargetKey, target);
	        return true;
        }

	    private Unit GetUnit(BTEnv env)
	    {
			Unit unit = env.Get<Unit>(this.UnitKey);
		    return unit;
	    }
    }
}

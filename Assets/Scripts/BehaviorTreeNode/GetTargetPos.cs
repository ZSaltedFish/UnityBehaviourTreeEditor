using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "获取目标点")]
    public class GetTargetPos : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

	    [NodeOutput("位置", typeof(Vector3))]
		public string PosKey;

		public GetTargetPos(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = GetUnit(env);
         //   Vector3 pos;
	        //if (!unit.GetComponent<TargetComponent>().GetTargetPos(out pos))
	        //{
		       // return false;
	        //}
	        //env.Add(this.PosKey, pos);
	        return true;
        }

	    private Unit GetUnit(BTEnv env)
	    {
			Unit unit = env.Get<Unit>(this.UnitKey);
		    return unit;
	    }
    }
}

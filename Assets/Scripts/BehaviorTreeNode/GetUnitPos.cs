using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "获取Unit位置")]
    public class GetUnitPos : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

	    [NodeOutput("位置", typeof(Vector3))]
		public string PosKey;

		public GetUnitPos(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = env.Get<Unit>(UnitKey);
	        //env.Add(PosKey, unit.Position);
	        return true;
        }
    }
}

using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "获取Unit位置")]
    public class GetUnitPosXZ : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

	    [NodeOutput("位置", typeof(Vector3))]
		public string PosKey;

		public GetUnitPosXZ(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = env.Get<Unit>(UnitKey);
	        //Vector3 pos = unit.Position;
	        //pos.y = 0;
	        //env.Add(this.PosKey, pos);
	        return true;
        }
    }
}

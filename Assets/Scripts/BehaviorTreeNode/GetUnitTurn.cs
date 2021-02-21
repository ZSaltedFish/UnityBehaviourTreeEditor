using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "获取Unit转向")]
    public class GetUnitTurn : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

	    [NodeOutput("转向", typeof(Quaternion))]
		public string QuaternionKey;

		public GetUnitTurn(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = env.Get<Unit>(UnitKey);
	        //Quaternion quaternion = unit.Rotation;
	        //env.Add(QuaternionKey, quaternion);
	        return true;
        }
    }
}

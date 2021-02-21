using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "Unit向某个位置移动")]
    public class MoveToPos : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

		[NodeInput("位置", typeof(Vector3))]
	    public string PosKey;

	    [NodeInput("速度", typeof(float))]
		public string SpeedKey;

		public MoveToPos(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = env.Get<Unit>(UnitKey);
	        //float speedValue = env.Get<float>(SpeedKey);
         //   Vector3 targetPos = env.Get<Vector3>(PosKey);
	        //MoveHelper.MoveToDest(unit, targetPos, speedValue);
			return true;
        }
    }
}

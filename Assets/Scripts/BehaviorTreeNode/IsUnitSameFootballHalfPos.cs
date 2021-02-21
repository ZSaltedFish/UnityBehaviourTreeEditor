using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "判断Unit跟足球是否在同一半场")]
    public class IsUnitSameFootballHalfPos : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

		public IsUnitSameFootballHalfPos(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = env.Get<Unit>(this.UnitKey);
	        //Unit football = FootBallHelper.GetFootBall();
	        //Vector3 pos = unit.Position;
	        //Vector3 footballPos = football.Position;
	        //float v = pos.x * footballPos.x;
	        //if (v > 0) // 同半场
	        //{
		       // return true;
	        //}

	        //if (v < 0) // 不同半场
	        //{
		       // return false;
	        //}
	        return true;
        }
    }
}

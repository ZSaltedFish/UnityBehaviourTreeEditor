using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "获取Unit面向对方球门的方向")]
    public class GetUnitToDoorTurn : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

	    [NodeOutput("向", typeof(Quaternion))]
		public string QuaternionKey;

	    [NodeField("偏转角度")]
	    public float Angle;

		public GetUnitToDoorTurn(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = env.Get<Unit>(this.UnitKey);
	        //int team = ActorHelper.MyActor().Team - 1;
	        //Unit goal = MapObjectComponent.Instance.GetUnits(MapObjectType.Goal)[team];

	        //Vector3 v = goal.Position - unit.Position;
	        //v = PositionHelper.GetAngleToQuaternion(this.Angle) * v;
	        //Quaternion quaternion = PositionHelper.GetVector3ToQuaternion(unit.Position, unit.Position + v);
	        //env.Add(this.QuaternionKey, quaternion);
	        return true;
        }
    }
}

using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "是否本队中离球最近")]
    public class IsNearest : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

        public IsNearest(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
			//Unit unit = env.Get<Unit>(this.UnitKey);
			//Unit football = FootBallHelper.GetFootBall();
			//float mindist = float.MaxValue;
			//Unit nearestUnit = unit;
			//foreach (Unit u in unit.Actor.GetAll())
			//{
			// float d = Vector3.SqrMagnitude(football.Position - u.Position);
			// if (d < mindist)
			// {
			//  nearestUnit = u;
			//  mindist = d;
			// }
			//}
			//return unit.Id == nearestUnit.Id;
			return true;
        }
    }
}

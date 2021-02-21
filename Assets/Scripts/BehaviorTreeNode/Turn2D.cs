using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "Unit改变2D面向")]
    public class Turn2D : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

	    [NodeInput("目标点", typeof(Vector3))]
	    public string TargetPos;

		public Turn2D(NodeProto nodeProto): base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	  //      Unit unit = env.Get<Unit>(this.UnitKey);
	  //      Vector3 targetPos = env.Get<Vector3>(this.TargetPos);
	  //      Vector3 dir = targetPos - unit.GameObject.transform.position;
			//unit.GetComponent<MotorComponent>().Turn2D(dir);
			return true;
        }
    }
}

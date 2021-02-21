using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "SetMoveLeftOrRight")]
    public class SetMoveLeftOrRight : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

		public SetMoveLeftOrRight(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = env.Get<Unit>(this.UnitKey);
	        //Vector3 speed = unit.GetComponent<MotorComponent>().MainSpeed;
	        //AnimatorComponent animatorComponent = unit.GetComponent<AnimatorComponent>();
	        //Vector3 forward = unit.GameObject.transform.forward;
	        //float v = FormulaHelper.CalculateAngle(forward, speed);
	        //if (v < 0 && v > -180) // 左
	        //{
		       // animatorComponent.SetIntValue("MoveDir", -1);
	        //}
	        //else if (v > 0 && v < 180) // 右
	        //{
		       // animatorComponent.SetIntValue("MoveDir", 1);
	        //}
	        //else
	        //{
		       // animatorComponent.SetIntValue("MoveDir", 0);
	        //}
			return true;
        }
    }
}

using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "SetMoveDirAnimator")]
    public class SetMoveDirAnimator : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

		public SetMoveDirAnimator(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = env.Get<Unit>(this.UnitKey);
	        //Vector3 speed = unit.GetComponent<MotorComponent>().MainSpeed;
	        //AnimatorComponent animatorComponent = unit.GetComponent<AnimatorComponent>();
	        //Vector3 forward = unit.GameObject.transform.forward;
	        //float angel = FormulaHelper.CalculateAngle(forward, speed);
	        //if (angel < 0)
	        //{
		       // angel += 360;
	        //}
	        //animatorComponent.SetFloatValue("MoveDirAngel", angel);
			return true;
        }
    }
}

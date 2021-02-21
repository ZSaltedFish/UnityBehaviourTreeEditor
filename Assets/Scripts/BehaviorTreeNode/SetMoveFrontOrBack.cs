using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "SetMoveFrontOrBack")]
    public class SetMoveFrontOrBack : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

		public SetMoveFrontOrBack(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = env.Get<Unit>(this.UnitKey);
	        //Vector3 speed = unit.GetComponent<MotorComponent>().MainSpeed;
	        //AnimatorComponent animatorComponent = unit.GetComponent<AnimatorComponent>();
	        //Vector3 forward = unit.GameObject.transform.forward;
	        //float v = FormulaHelper.CalculateAngle(forward, speed);
	        //if (v > 90 || v < -90) // 后
	        //{
		       // animatorComponent.SetIntValue("MoveDirFrontOrBack", -1);
	        //}
	        //else if (v < 90 && v > -90) // 前
	        //{
		       // animatorComponent.SetIntValue("MoveDirFrontOrBack", 1);
	        //}
	        //else
	        //{
		       // animatorComponent.SetIntValue("MoveDirFrontOrBack", 0);
	        //}
			return true;
        }
    }
}

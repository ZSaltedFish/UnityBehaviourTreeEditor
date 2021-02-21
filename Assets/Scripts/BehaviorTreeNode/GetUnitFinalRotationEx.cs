namespace Model
{
    [Node(NodeClassifyType.Action, "朝向最终转向")]
    public class GetUnitFinalRotationEx : Node
    {
        [NodeInput("朝向者", typeof(Unit))]
        public string UnitInput;
        public GetUnitFinalRotationEx(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit unit = env.Get<Unit>(UnitInput);

            //if (unit == null)
            //{
            //    return false;
            //}
            //TargetComponent targetComponent = unit.GetComponent<TargetComponent>();
            //if (targetComponent == null)
            //{
            //    return false;
            //}
            //Unit target = targetComponent.Target;
            //if (target == null)
            //{
            //    return false;
            //}
            //MotorComponent motor = target.GetComponent<MotorComponent>();
            //unit.GameObject.transform.rotation = motor.GetFinalRotation();
            return true;
        }
    }
}

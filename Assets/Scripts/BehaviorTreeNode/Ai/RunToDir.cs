using UnityEngine;
/*
namespace Model
{
    [Node(NodeClassifyType.Action, "跑动")]
    public class RunToDir : Node
    {
        [NodeInput("手柄方向换算移动点", typeof(Vector3))]
        public string Direction;

        [NodeInput("单位", typeof(Unit))]
        public string UnitName;

        public RunToDir(NodeProto nodeProto): base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            Vector3 dire = env.Get<Vector3>(Direction);
            Unit unit = env.Get<Unit>(UnitName);
            MotorComponent motor = unit.GetComponent<MotorComponent>();
            float speed = unit.GetComponent<NumericComponent>()[NumericType.Speed] / 100f;
            motor.MoveToDir(dire.normalized * speed);
            motor.Turn2D(dire, 0.2f);
            return true;
        }
    }
}
*/
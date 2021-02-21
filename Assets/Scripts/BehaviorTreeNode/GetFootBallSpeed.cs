using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "获取足球的速度")]
    public class GetFootBallSpeed : Node
    {
        [NodeOutput("速度", typeof(Vector3))]
        public string SpeedKey;

        public GetFootBallSpeed(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
   //         Unit unit = FootBallHelper.GetFootBall();
   //         Vector3 speed = unit.GetComponent<FootballMotorComponent>().Speed;
			//env.Add(this.SpeedKey, speed);
            return true;
        }
    }
}

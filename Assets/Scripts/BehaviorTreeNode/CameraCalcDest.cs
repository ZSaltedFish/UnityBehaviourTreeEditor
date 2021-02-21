using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "计算摄像机下个移动目标")]
    public class CameraCalcDest : Node
    {
	    [NodeOutput("目标unit", typeof(Vector3))]
		public string V;

		public CameraCalcDest(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Vector3 dest = CameraMotorComponent.Instance.CalDest();
	        //env.Add(this.V, dest);
	        return true;
        }
    }
}

using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "移动摄像机到下个目标")]
    public class CameraMoveToDest : Node
    {
	    [NodeInput("目标位置", typeof(Vector3))]
		public string DestPost;

		public CameraMoveToDest(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        Vector3 dest = env.Get<Vector3>(DestPost);
	        //CameraMotorComponent.Instance.MoveToDest(dest);
	        return true;
        }
    }
}

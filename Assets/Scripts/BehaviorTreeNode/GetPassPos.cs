using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "获取足球落点位置")]
    public class GetPassPos : Node
    {
	    [NodeOutput("位置", typeof(Vector3))]
		public string PosKey;

		public GetPassPos(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //env.Add(this.PosKey, FootBallHelper.GetFootBall().GetComponent<PassComponent>().Pos);
	        return true;
        }
    }
}

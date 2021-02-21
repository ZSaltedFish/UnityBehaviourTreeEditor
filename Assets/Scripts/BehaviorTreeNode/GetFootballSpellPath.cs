using UnityEngine;

namespace Model
{
	[Node(NodeClassifyType.Action, "Football spell path move")]
	public class GetFootballSpellPath : Node
	{
		[NodeOutput("位置", typeof(Vector3))]
		public string PosKey;

		public GetFootballSpellPath(NodeProto nodeProto): base(nodeProto)
		{
		}

		protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
		{
			//FootBallSpellPathTargetComponent footBallSpellPathTargetComponent = FootBallHelper.GetFootBall()?.GetComponent<FootBallSpellPathTargetComponent>();
			//if (footBallSpellPathTargetComponent == null)
			//{
			//	return false;
			//}
			
			//env.Add(this.PosKey, footBallSpellPathTargetComponent.TargetPos);
			return true;
		}
	}
}
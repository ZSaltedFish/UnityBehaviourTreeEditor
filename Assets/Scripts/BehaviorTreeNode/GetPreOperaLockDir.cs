using UnityEngine;

namespace Model
{
	[Node(NodeClassifyType.Action, "GetPreOperaLockDir")]
	public class GetPreOperaLockDir : Node
	{
		[NodeInput("Unit", typeof(Unit))]
		public string UnitKey;

		[NodeOutput("Dir", typeof(Vector3))]
		public string DirKey;

		public GetPreOperaLockDir(NodeProto nodeProto): base(nodeProto)
		{
		}

		protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
		{
			//Unit unit = env.Get<Unit>(this.UnitKey);
			//PreOperaLockDirComponent lockDirComponent = unit.GetComponent<PreOperaLockDirComponent>();
			//if (lockDirComponent == null)
			//{
			//	return false;
			//}
			
			//env.Add(this.DirKey, lockDirComponent.Dir);
			return true;
		}
	}
}
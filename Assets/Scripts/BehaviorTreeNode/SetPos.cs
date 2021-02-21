using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "设置Unit位置")]
    public class SetPos : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

		[NodeInput("位置点", typeof(Vector3))]
	    public string PosKey;

		public SetPos(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        Unit unit = env.Get<Unit>(this.UnitKey);
	        //unit.Position = env.Get<Vector3>(this.PosKey);
			return true;
        }
    }
}

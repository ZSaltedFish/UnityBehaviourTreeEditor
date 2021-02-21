using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "设置Unit是否可见,计数")]
    public class SetUnitVisiableCount : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

		[NodeField("是否可见")]
	    public bool Visiable;

		public SetUnitVisiableCount(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = env.Get<Unit>(this.UnitKey);
	        //unit.SetVisiableByCount(this.Visiable);
			return true;
        }
    }
}

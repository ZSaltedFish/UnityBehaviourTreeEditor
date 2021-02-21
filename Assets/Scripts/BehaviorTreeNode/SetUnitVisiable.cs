using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "设置Unit是否可见")]
    public class SetUnitVisiable : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

		[NodeField("是否可见")]
	    public bool Visiable;

		public SetUnitVisiable(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = env.Get<Unit>(this.UnitKey);
	        //unit.SetVisiable(this.Visiable);
			return true;
        }
    }
}

using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "设置RootMotion")]
    public class ApplyRootMotion : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

	    [NodeField("Value", typeof(bool))]
	    public bool Value;

		public ApplyRootMotion(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        Unit unit = env.Get<Unit>(this.UnitKey);

	        //unit.GameObject.GetComponent<Animator>().applyRootMotion = this.Value;

	        return true;
        }
    }
}

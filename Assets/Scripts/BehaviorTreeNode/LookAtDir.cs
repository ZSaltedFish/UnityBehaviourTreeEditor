using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "面向方向")]
    public class LookAtDir : Node
    {
	    [NodeInput("A点", typeof(Unit))]
	    public string UnitKey;

	    [NodeInput("Dir", typeof(Vector3))]
		public string Dir;

		public LookAtDir(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = env.Get<Unit>(this.UnitKey);
         //   Vector3 dir = env.Get<Vector3>(this.Dir);
	        //Vector3 lookAtTarget = unit.GameObject.transform.position + dir;
	        //unit.GameObject.transform.LookAt(lookAtTarget);
	        return true;
        }
    }
}

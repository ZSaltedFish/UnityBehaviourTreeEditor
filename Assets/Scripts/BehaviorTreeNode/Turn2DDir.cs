using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "Unit改变2D面向")]
    public class Turn2DDir : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

	    [NodeInput("方向", typeof(Vector3))]
	    public string DirKey;

		public Turn2DDir(NodeProto nodeProto): base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	  //      Unit unit = env.Get<Unit>(this.UnitKey);
	  //      Vector3 dir = env.Get<Vector3>(this.DirKey);
			//unit.GetComponent<MotorComponent>().Turn2D(dir);
			return true;
        }
    }
}

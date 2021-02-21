using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "Unit向某个方向移动,不改变面向")]
    public class MoveToDir : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

	    [NodeField("速度")]
	    public int Speed;

	    [NodeInput("移动方向", typeof(Vector3))]
	    public string Direction;

		public MoveToDir(NodeProto nodeProto): base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	  //      Unit unit = env.Get<Unit>(UnitKey);
	  //      Vector3 dire = env.Get<Vector3>(Direction);
	  //      dire = dire.normalized * this.Speed;
			//unit.GetComponent<MotorComponent>().MoveToDir(dire);
			return true;
        }
    }
}

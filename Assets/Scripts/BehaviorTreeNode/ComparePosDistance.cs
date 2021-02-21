using System;
using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "球员某点距离比较")]
    public class ComparePosDistance : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

	    [NodeInput("Pos", typeof(Vector3))]
	    public string PosKey;

		[NodeField("比较符")]
	    public Operator Operator;

	    [NodeField("比较值")]
	    public float Value;

		public ComparePosDistance(NodeProto nodeProto): base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
         //   Unit unit = env.Get<Unit>(UnitKey);
	        //Vector3 pos = env.Get<Vector3>(this.PosKey);
	        //float distance = Vector3.Distance(unit.Position, pos);
	        //switch (Operator)
	        //{
		       // case Operator.EQ:
			      //  return Math.Abs(distance - this.Value) < 0.01;
		       // case Operator.GE:
			      //  return distance >= this.Value;
		       // case Operator.GT:
			      //  return distance > this.Value;
		       // case Operator.LE:
			      //  return distance <= this.Value;
		       // case Operator.LT:
			      //  return distance < this.Value;
	        //}
	        return false;
        }
    }
}

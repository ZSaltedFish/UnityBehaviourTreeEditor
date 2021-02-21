using System;

namespace Model
{
    [Node(NodeClassifyType.Condition, "球员与足球距离比较")]
    public class CompareFootballDistance : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

	    [NodeField("比较符")]
	    public Operator Operator;

	    [NodeField("比较值")]
	    public float Value;

		public CompareFootballDistance(NodeProto nodeProto): base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
         //   Unit unit = env.Get<Unit>(UnitKey);
	        //float distance = FootBallHelper.GetFootballDistance(unit);
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

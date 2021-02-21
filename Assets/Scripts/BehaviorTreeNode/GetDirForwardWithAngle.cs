using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "计算Unit朝向偏转angle角度的向量")]
    public class GetDirForwardWithAngle : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;
		
		[NodeField("与forward的角度")]
		public int Angle;

	    [NodeOutput("Vector3", typeof(Vector3))]
	    public string DirKey;

		public GetDirForwardWithAngle(NodeProto nodeProto): base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = env.Get<Unit>(UnitKey);
	        //Vector3 pointDir = Quaternion.AngleAxis(Angle, Vector3.up) * unit.GameObject.transform.forward;
	        //env.Add(this.DirKey, pointDir);
			return true;
        }
    }
}

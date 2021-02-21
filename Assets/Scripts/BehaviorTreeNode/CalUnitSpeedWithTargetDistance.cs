using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "根据目标的距离，计算运行速度")]
    public class CalUnitSpeedWithTargetDistance : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

		[NodeInput("位置", typeof(Vector3))]
	    public string PosKey;
	    
	    [NodeField("乘数")]
	    public float Multiply;
	    
	    [NodeField("MinValue")]
	    public float Min;
	    
	    [NodeField("MaxValue")]
	    public float Max;

	    [NodeOutput("速度", typeof(float))]
		public string SpeedKey;

		public CalUnitSpeedWithTargetDistance(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit unit = env.Get<Unit>(this.UnitKey);
	        //Vector3 pos = env.Get<Vector3>(this.PosKey);
	        //float distance = Vector3.Distance(unit.Position, pos);
	        //float v = distance * this.Multiply;
	        //Unit owner = UnitHelper.GetUnit(FootballMotorComponent.Instance.OwnerId);
	        //float ownerV = owner.GetComponent<MotorComponent>().MainSpeed.magnitude;
	        //float v2 = 0;
	        //v += ownerV;
	        //if (v < this.Min)
	        //{
		       // v2 = this.Min;
	        //}
	        //else if (v > this.Max)
	        //{
		       // v2 = this.Max;
	        //}
	        //else
	        //{
		       // v2 = v;
	        //}
	        
	        //env.Add(this.SpeedKey, v2);
	        
			return true;
        }
    }
}

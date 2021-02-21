using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "选择扇形范围内目标")]
    public class SelectTargetInSector : Node
    {
        [NodeInput("Caster", typeof(Unit))]
        public string Caster;

	    [NodeInput("Dir", typeof(Vector3))]
	    public string Dir;

		[NodeField("是否同一队")]
	    public bool SameTeam;

	    [NodeField("最小角度, -180 ~ 180")]
	    public int From;

	    [NodeField("最大角度, -180 ~ 180")]
	    public int To;

	    [NodeField("距离")]
	    public float Distance;

	    [NodeOutput("SelectedUnits", typeof(List<Unit>))]
	    public string SelectedUnits;

		public SelectTargetInSector(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	  //      Unit a = env.Get<Unit>(this.Caster);
	  //      Vector3 dir = env.Get<Vector3>(this.Dir);
			//Unit[] allUnits = UnitComponent.Instance.GetUnits(UnitType.Player);
			//List<Unit> result = new List<Unit>();
	  //      float minAngle = 1000;
	  //      foreach (Unit unit in allUnits)
	  //      {
		 //       if (SelectTargetHelper.IsSameTeam(a, unit) != this.SameTeam)
		 //       {
			//        continue;
		 //       }

		 //       if (SelectTargetHelper.Distance(a, unit) > Distance)
		 //       {
			//		continue;
		 //       }

		 //       float angle = Vector3.Angle(dir, unit.Position - a.Position);
		 //       if (angle > this.To)
		 //       {
			//		continue;
		 //       }
		 //       if (angle < this.From)
		 //       {
			//		continue;
		 //       }
		 //       if (angle < minAngle)
		 //       {
			//        minAngle = angle;
			//        result.Insert(0, unit);
		 //       }
		 //       else
		 //       {
			//		result.Add(unit);
			//	}
			//}
	  //      env.Add(this.SelectedUnits, result);
	        return true;
        }
    }
}

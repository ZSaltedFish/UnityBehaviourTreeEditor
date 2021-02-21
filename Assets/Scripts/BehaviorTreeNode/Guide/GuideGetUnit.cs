using System.Collections.Generic;

namespace Model
{
    public enum GuideUnitType
    {
        MyCtrlUnit,
        NonCtrlUnit,
        EnemyUnit
    }

    [Node(NodeClassifyType.Action, "新手引导获取单位")]
    public class GuideGetUnit : Node
    {
        [NodeField("单位类型")]
        public GuideUnitType UnitType = GuideUnitType.MyCtrlUnit;
        [NodeOutput("单位输出", typeof(Unit))]
        public string OutputUnit;
        public GuideGetUnit(NodeProto p) : base(p)
        {

        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit unit = null;
            //switch (UnitType)
            //{
            //    case GuideUnitType.MyCtrlUnit:
            //        unit = UnitHelper.GetMyUnit();
            //        break;
            //    case GuideUnitType.NonCtrlUnit:
            //        List<Unit> units = new List<Unit>(UnitHelper.GetTeamUnits(true));
            //        unit = GetOtherUnit(units);
            //        break;
            //    case GuideUnitType.EnemyUnit:
            //        unit = GetOtherUnit(new List<Unit>(UnitHelper.GetTeamUnits(false)));
            //        break;
            //}
            
            //env.Add(OutputUnit, unit);
            return true;
        }
    }
}

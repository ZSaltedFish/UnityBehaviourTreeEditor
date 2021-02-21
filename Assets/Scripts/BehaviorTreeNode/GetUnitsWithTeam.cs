using System;

namespace Model
{
    [Node(NodeClassifyType.DataTransform, "获取指定队伍中的所有球员")]
    public class GetUnitsWithTeam : Node
    {
        [NodeField("True则选择队友，否则选择对方球员")]
        public bool IsTeamMate;
        [NodeOutput("球员列表", typeof(Unit[]))]
        public string UnitsStr;
        public GetUnitsWithTeam(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit[] units = UnitHelper.GetTeamUnits(IsTeamMate);
            //env.Add(UnitsStr, units);
            return true;
        }
    }
}

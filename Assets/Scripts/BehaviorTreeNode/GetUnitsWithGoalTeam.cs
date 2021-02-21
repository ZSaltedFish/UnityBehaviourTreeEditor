using System;
using System.Collections.Generic;

namespace Model
{
    [Node(NodeClassifyType.Condition, "获取指进球队伍中的所有球员")]
    public class GetUnitsWithGoalTeam : Node
    {
        [NodeOutput("球员列表", typeof(Unit[]))]
        public string UnitsStr;

        public GetUnitsWithGoalTeam(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit[] units = UnitHelper.GetTeamUnits(GameStateComponent.Instance.IsMyTeamGold);
         //   env.Add(UnitsStr, units);
            return true;
        }
    }
}

using System;
using System.Collections.Generic;

namespace Model
{
    [Node(NodeClassifyType.Condition, "获取其他球员")]
    public class GetOtherPlayerUnits : Node
    {
        [NodeInput("Unit", typeof (Unit))]
        public string UnitKey;
        
        [NodeOutput("球员列表", typeof(List<Unit>))]
        public string Units;

        public GetOtherPlayerUnits(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //List<Unit> units = new List<Unit>();
            //Unit unit = env.Get<Unit>(this.UnitKey);
            //Unit[] players = UnitComponent.Instance.GetUnits(UnitType.Player);
            //foreach (Unit player in players)
            //{
            //    if (player.Id == unit.Id)
            //    {
            //        continue;
            //    }
            //    units.Add(player);
            //}
            //env.Add(Units, units);
            return true;
        }
    }
}

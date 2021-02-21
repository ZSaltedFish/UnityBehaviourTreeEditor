using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "Unit remove Buff in units")]
    public class RemoveBuffInPlayers : Node
    {
        [NodeInput("Units", typeof(Unit[]))]
	    public string UnitKey;

        [NodeField("buff config id")]
        public int BuffConfigId;

        public RemoveBuffInPlayers(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit[] units = env.Get<Unit[]>(UnitKey);
            //if (units != null)
            //{
            //    foreach (Unit unit in units)
            //    {
            //        unit.GetComponent<BuffComponent>().RemoveType(this.BuffConfigId);
            //    }
            //}
            return true;
        }
    }
}

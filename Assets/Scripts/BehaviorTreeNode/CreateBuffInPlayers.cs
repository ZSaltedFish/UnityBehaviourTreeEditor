using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "Units加Buff")]
    public class CreateBuffInPlayers : Node
    {
        [NodeField("Buff")]
        public GameObject BuffConfig;

	    [NodeInput("Units", typeof(Unit[]))]
	    public string UnitsKey;

        public CreateBuffInPlayers(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit[] units = env.Get<Unit[]>(UnitsKey);
            //if(units != null)
            //{
            //    foreach(Unit unit in units)
            //    {
            //        BuffFactory.Create(unit, BuffConfig);
            //    }
            //}
            return true;
        }
    }
}

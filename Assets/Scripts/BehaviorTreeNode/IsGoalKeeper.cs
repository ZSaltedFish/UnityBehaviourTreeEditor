using System;
using System.Collections.Generic;

namespace Model
{
    [Node(NodeClassifyType.Condition, "是否是守门员")]
    public class IsGoalKeeper : Node
    {
        [NodeInput("球员Unit", typeof(Unit))]
        public string UnitKey;

        public IsGoalKeeper(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit unit = env.Get<Unit>(this.UnitKey);
            //if (unit.GetConfig<UnitMonoConfig>().Id == 1014)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return true;
        }
    }
}

using System.Collections.Generic;

namespace Model
{
    [Node(NodeClassifyType.DataTransform, "在Unit数组中获取其中一个Unit")]
    public class GetUnitInListByIndex : Node
    {
        [NodeField("索引", 0)]
        public int Index;
        [NodeInput("输入数组", typeof(List<Unit>))]
        public string InputList;
        [NodeOutput("输出单位", typeof(Unit))]
        public string OutputUnit;
        public GetUnitInListByIndex(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            List<Unit> units = env.Get<List<Unit>>(InputList);
            Unit unit = units[Index];
            env.Add(OutputUnit, unit);
            return true;
        }
    }
}

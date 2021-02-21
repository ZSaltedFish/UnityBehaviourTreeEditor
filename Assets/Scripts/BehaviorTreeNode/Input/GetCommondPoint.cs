using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.DataTransform, "获取命令的点")]
    public class GetCommondPoint : Node
    {
        [NodeInput("角色", typeof(Unit))]
        public string UnitName;
        [NodeOutput("位置", typeof(Vector3))]
        public string DataOutput;
        public GetCommondPoint(NodeProto nodeProto): base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit unit = env.Get<Unit>(UnitName);
            //UnitDataComponent comp = unit.GetComponent<UnitDataComponent>();
            //Vector3 v = comp.CommondPoint;
            //env.Add(DataOutput, v);
            return true;
        }
    }
}

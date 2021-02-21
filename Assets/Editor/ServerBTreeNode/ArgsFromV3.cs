using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "类型转换从vector3")]
    public class ArgsFromV3 : Node
    {
        public ArgsFromV3(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("输入值", typeof(Vector3))]
        public string InValue;

        [NodeOutput("转换值", typeof(System.Object))]
        public string Value;
    }
}
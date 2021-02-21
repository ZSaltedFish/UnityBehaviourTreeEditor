using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "类型转换vector3")]
    public class ArgsToV3 : Node
    {
        public ArgsToV3(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("输入值", typeof(System.Object))]
        public string InValue;

        [NodeOutput("转换值", typeof(Vector3))]
        public string Value;
    }
}
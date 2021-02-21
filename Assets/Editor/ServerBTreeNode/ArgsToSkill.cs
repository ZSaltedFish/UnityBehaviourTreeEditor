using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "类型转换skill")]
    public class ArgsToSkill : Node
    {
        public ArgsToSkill(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("输入值", typeof(System.Object))]
        public string InValue;

        [NodeOutput("转换值", typeof(Server.Skill))]
        public string Value;
    }
}
using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "类型转换从Skill")]
    public class ArgsFromSkill : Node
    {
        public ArgsFromSkill(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("输入值", typeof(Server.Skill))]
        public string InValue;

        [NodeOutput("转换值", typeof(System.Object))]
        public string Value;
    }
}
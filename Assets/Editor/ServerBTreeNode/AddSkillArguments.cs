using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "添加技能通知参数")]
    public class AddSkillArguments : Node
    {
        public AddSkillArguments(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("键")]
        public string Key;

        [NodeField("值(可选)")]
        public int Value;

        [NodeInput("技能(可选)", typeof(Server.Skill))]
        public string Self;

        [NodeInput("参数(可选)", typeof(Server.Args))]
        public string Args;

        [NodeInput("输入值(可选)", typeof(double))]
        public string InValue;
    }
}
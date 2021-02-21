using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "添加技能通知参数")]
    public class AddSkillNotice : Node
    {
        public AddSkillNotice(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("键")]
        public string Key;

        [NodeField("值(可选)")]
        public int Value;

        [NodeInput("技能", typeof(Server.Skill))]
        public string Self;

        [NodeInput("输入值(可选)", typeof(int))]
        public string InValue;
    }
}
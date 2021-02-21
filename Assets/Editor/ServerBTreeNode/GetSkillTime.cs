using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取技能时间")]
    public class GetSkillTime : Node
    {
        public GetSkillTime(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("0总时间，1前摇时间, 2动作时间")]
        public int TimeType;

        [NodeField("是否重置时间")]
        public bool Reset;

        [NodeInput("技能", typeof(Server.Skill))]
        public string Self;

        [NodeInput("球员(可选)", typeof(Server.Unit))]
        public string Owner;

        [NodeOutput("技能时间", typeof(double))]
        public string SkillTime;
    }
}
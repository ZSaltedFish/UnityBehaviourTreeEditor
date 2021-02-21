using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取基本技能时间(表)")]
    public class GetBaseSkillTime : Node
    {
        public GetBaseSkillTime(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("0总时间，1前摇时间, 2动作时间")]
        public int TimeType;

        [NodeInput("技能ID", typeof(int))]
        public string SkillID;

        [NodeInput("球员(可选)", typeof(Server.Unit))]
        public string Owner;

        [NodeOutput("技能时间", typeof(double))]
        public string SkillTime;
    }
}
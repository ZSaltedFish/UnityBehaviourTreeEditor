using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "执行子树(技能)")]
    public class DoSkillTree : Node
    {
        public DoSkillTree(NodeProto nodeProto) : base(nodeProto) { }
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("子树名", envKeyType = typeof(ServerSubTree))]
        public string Script;

        [NodeInput("技能", typeof(Server.Skill))]
        public string Skill;

        [NodeInput("所有者球员", typeof(Server.Unit))]
        public string Owner;

        [NodeInput("参数", typeof(Server.Args))]
        public string Args;
    }
}

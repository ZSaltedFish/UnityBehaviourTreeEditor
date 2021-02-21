using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Root, "Skill根节点")]
    public class SkillRoot : Node
    {
        public SkillRoot(NodeProto nodeProto) : base(nodeProto) { }
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeOutput("技能对象", typeof(Server.Skill))]
        public string Self;

        [NodeOutput("施放者", typeof(Server.Unit))]
        public string Owner;

        [NodeOutput("触发状态", typeof(double))]
        public string State;

        [NodeOutput("参数", typeof(Server.Args))]
        public string Args;

        [NodeOutput("Any", typeof(BeHaviourAnyType))]
        public string Null;
    }
}

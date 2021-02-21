using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取基本属性/配置")]
    public class GetSkillAttr : Node
    {
        public GetSkillAttr(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("属性/配置名")]
        public eSkillAttr Attr;

        [NodeInput("技能", typeof(Server.Skill))]
        public string Self;

        [NodeOutput("值", typeof(double))]
        public string Value;
    }
}
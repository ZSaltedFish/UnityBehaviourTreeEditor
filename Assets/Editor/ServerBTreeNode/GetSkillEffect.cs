using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取技能影响属性")]
    public class GetSkillEffect : Node
    {
        public GetSkillEffect(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("属性")]
        public string Attr;

        [NodeInput("技能对象", typeof(Server.Skill))]
        public string Self;

        [NodeOutput("输出值", typeof(double))]
        public string Value;
    }
}
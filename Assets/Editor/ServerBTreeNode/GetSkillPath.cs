using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取技能移动路径")]
    public class GetSkillPath : Node
    {
        public GetSkillPath(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("技能", typeof(Server.Skill))]
        public string Self;

        [NodeInput("Buff", typeof(Server.Buff))]
        public string Buff;

        [NodeInput("球员(可选)", typeof(Server.Unit))]
        public string Owner;

        [NodeInput("索引(默认1)", typeof(double))]
        public string Idx;

        [NodeOutput("输出方向", typeof(Server.Vector3))]
        public string Dir;

        [NodeOutput("速度", typeof(double))]
        public string Speed;
    }
}
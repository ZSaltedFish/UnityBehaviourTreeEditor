using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "添加一个buff(Unit)")]
    public class CreateBuff : Node
    {
        public CreateBuff(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("BuffID(可选)")]
        public int BuffID;

        [NodeInput("BuffID(可选)", typeof(double))]
        public string InBuffID;

        [NodeInput("技能(可选)", typeof(Server.Skill))]
        public string Skill;

        [NodeInput("球员/球", typeof(Server.Object))]
        public string Self;

        [NodeInput("参数", typeof(Server.Args))]
        public string Args;

    }
}
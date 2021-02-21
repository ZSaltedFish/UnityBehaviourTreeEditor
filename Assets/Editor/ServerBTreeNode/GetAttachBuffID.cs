using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取技能附属BuffID")]
    public class GetAttachBuffID : Node
    {
        public GetAttachBuffID(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("索引")]
        public int Index;

        [NodeInput("技能对象", typeof(Server.Skill))]
        public string Self;

        [NodeOutput("输出BuffID", typeof(double))]
        public string BuffID;
    }
}
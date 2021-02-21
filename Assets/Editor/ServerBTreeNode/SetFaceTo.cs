using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "设置单位朝向(目标)")]
    public class SetFaceTo : Node
    {
        public SetFaceTo(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("是否延时通知")]
        public bool IsLower;

        [NodeField("即时转向(客户端)")]
        public bool IsFast;

        [NodeField("是否不通知客户端")]
        public bool IsSilent;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("朝向(可选)", typeof(Vector3))]
        public string Dir;

        [NodeInput("目标(可选)", typeof(Server.Object))]
        public string Target;

    }
}
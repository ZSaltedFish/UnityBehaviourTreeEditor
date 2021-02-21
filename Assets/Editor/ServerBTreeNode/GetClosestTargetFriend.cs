using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "取最靠近目标对象的友方成员")]
    public class GetClosestTargetFriend : Node
    {
        public GetClosestTargetFriend(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("true最近,false最远")]
        public bool IsNear;

        [NodeField("目标 1球,2对方球门,3本方球门")]
        public int TargetType;

        [NodeField("包含守门员")]
        public bool with_keeper;

        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("最近队友", typeof(Server.Unit))]
        public string Other;
    }
}
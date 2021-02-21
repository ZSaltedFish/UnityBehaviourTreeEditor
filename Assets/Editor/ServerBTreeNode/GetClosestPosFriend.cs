using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "取最靠近目标点的友方成员")]
    public class GetClosestPosFriend : Node
    {
        public GetClosestPosFriend(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("true最近,false最远")]
        public bool IsNear;

        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("位置", typeof(Server.Vector3))]
        public string Pos;

        [NodeOutput("最近队友", typeof(Server.Unit))]
        public string Other;
    }
}
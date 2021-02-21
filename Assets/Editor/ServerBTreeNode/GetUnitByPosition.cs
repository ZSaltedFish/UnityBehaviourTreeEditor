using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "取最靠近目标对象的友方成员")]
    public class GetUnitByPosition : Node
    {
        public GetUnitByPosition(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("位置(前中后卫)")]
        public int Position;

        [NodeField("true队友,false敌人")]
        public bool IsFriend;

        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("目标球员", typeof(Server.Unit))]
        public string Other;
    }
}
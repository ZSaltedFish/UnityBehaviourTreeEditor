using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "是否指定职业")]
    public class IsPosition : Node
    {
        public IsPosition(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("位置(前中后卫)")]
        public int Position;
        
        [NodeInput("本球员", typeof(Server.Unit))]
        public string Self;
    }
}
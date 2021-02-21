using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "检查位置高度")]
    public class CheckHeight : Node
    {
        public CheckHeight(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("高: 正数为大于,负数为小于")]
        public double Height;
        
        [NodeInput("位置", typeof(Server.Vector3))]
        public string Pos;
    }
}
using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "获取控球者")]
    public class GetBallControler : Node
    {
        public GetBallControler(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("true最后持球,false为当前持球")]
        public bool IsLast;
        
        [NodeOutput("球员", typeof(Server.Unit))]
        public string Unit;
        
    }
}
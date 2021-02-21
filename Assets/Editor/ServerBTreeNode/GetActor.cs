using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "取所有者")]
    public class GetActor : Node
    {
        public GetActor(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("场景对象", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("所有者", typeof(Server.Actor))]
        public string Actor;
    }
}
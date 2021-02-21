using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "检查或重置传球目标")]
    public class CheckPassTarget : Node
    {
        public CheckPassTarget(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("是否重置(false为只检查)")]
        public bool Reset;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;
        
    }
}
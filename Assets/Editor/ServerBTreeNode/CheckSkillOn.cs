using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "检查是否在施法中")]
    public class CheckSkillOn : Node
    {
        public CheckSkillOn(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
 
        [NodeInput("球员", typeof(Server.Unit))]
        public string Owner;
    }
}
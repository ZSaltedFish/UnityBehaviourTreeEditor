using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "查技能是否异常退出")]
    public class CheckException : Node
    {
        public CheckException(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("技能对象", typeof(Server.Skill))]
        public string Self;
        
    }
}
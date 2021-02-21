using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "锁朝向lockface")]
    public class LockfaceTo : Node
    {
        public LockfaceTo(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeInput("目标(可选)", typeof(Server.Object))]
        public string Other;

        [NodeInput("朝向(可选)", typeof(Server.Vector3))]
        public string Dir;
    }
}
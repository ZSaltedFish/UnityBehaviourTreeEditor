using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "获取单位朝向")]
    public class GetFaceDir : Node
    {
        public GetFaceDir(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("朝向", typeof(Server.Vector3))]
        public string Dir;
    }
}
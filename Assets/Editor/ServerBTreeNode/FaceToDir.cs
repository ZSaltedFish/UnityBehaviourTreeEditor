using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "角度转方向")]
    public class FaceToDir : Node
    {
        public FaceToDir(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("角度", typeof(double))]
        public string Face;

        [NodeOutput("方向", typeof(Server.Vector3))]
        public string Dir;
    }
}
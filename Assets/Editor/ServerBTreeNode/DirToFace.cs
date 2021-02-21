using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "方向转角度")]
    public class DirToFace : Node
    {
        public DirToFace(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }
        
        [NodeInput("方向", typeof(Server.Vector3))]
        public string Dir;

        [NodeOutput("角度", typeof(double))]
        public string Face;
    }
}
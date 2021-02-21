using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "设置球高度")]
    public class SetBallHeight : Node
    {
        public SetBallHeight(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("高度")]
        public double Height;
        
        [NodeInput("球", typeof(Server.Ball))]
        public string Ball;
    }
}
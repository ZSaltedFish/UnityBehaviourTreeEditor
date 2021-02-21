using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取球门位置")]
    public class GetGoal : Node
    {
        public GetGoal(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("球门类型 1攻,2防,3友,4敌")]
        public int GType;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("球门", typeof(Server.Goal))]
        public string Goal;
    }
}
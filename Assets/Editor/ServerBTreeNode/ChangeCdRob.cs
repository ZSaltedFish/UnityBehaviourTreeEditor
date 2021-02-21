using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "添加抢球或被抢(球)cd")]
    public class ChangeCdRob : Node
    {
        public ChangeCdRob(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("CD时间(秒)")]
        public double CDTime;

        [NodeInput("场景对象(球员或球)", typeof(Server.Object))]
        public string Self;
    }
}
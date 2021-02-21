using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "停止场景对象移动")]
    public class StopObject : Node
    {
        public StopObject(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("是否控制停止")]
        public bool IsCtl;

        [NodeInput("场景对象(球或球员)", typeof(Server.Object))]
        public string Self;
        
    }
}
using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "设置按键cd时间")]
    public class SetButtonCD : Node
    {
        public SetButtonCD(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("按键id")]
        public eButtonCD ButtonID;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Unit;
    }
}
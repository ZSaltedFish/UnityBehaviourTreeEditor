using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Root, "Buff根节点")]
    public class BuffRoot : Node
    {
        public BuffRoot(NodeProto nodeProto) : base(nodeProto) { }
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeOutput("Buff对象", typeof(Server.Buff))]
        public string Self;

        [NodeOutput("相关Skill", typeof(Server.Skill))]
        public string Skill;

        [NodeOutput("所有者(作用目标)", typeof(Server.Object))]
        public string Owner;

        [NodeOutput("触发状态", typeof(double))]
        public string State;

        [NodeOutput("参数", typeof(Server.Args))]
        public string Args;

        [NodeOutput("Any", typeof(BeHaviourAnyType))]
        public string Null;
    }
}

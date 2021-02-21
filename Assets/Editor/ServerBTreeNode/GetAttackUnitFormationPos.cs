using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取进攻阵型")]
    public class GetAttackUnitFormationPos : Node
    {
        public GetAttackUnitFormationPos(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;


    }
}
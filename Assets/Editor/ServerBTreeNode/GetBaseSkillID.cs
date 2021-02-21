using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "检查并获取佩戴的技能ID(技能基本ID)")]
    public class GetBaseSkillID : Node
    {
        public GetBaseSkillID(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("是否检查cd,true在CD期间返回false")]
        public bool CheckCD;

        [NodeField("技能基本ID")]
        public int SkillBaseID;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("技能ID", typeof(int))]
        public string SkillID;
        
    }
}
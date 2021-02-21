using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Action, "获取AI属性值")]
    public class GetAILevelConfigAttrValue : Node
    {
        public GetAILevelConfigAttrValue(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }



        [NodeField("属性名称")]
        public eAIAttr Attr;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;

        [NodeOutput("输出值", typeof(double))]
        public string Value;


    }
}
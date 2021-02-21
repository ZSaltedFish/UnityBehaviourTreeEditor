using System;

namespace Model
{
    [Node(NodeClassifyType.Error, "节点丢失")]
    public class MissinNode : Node
    {
        [NodeInput("错误的节点", typeof(Node))]
        public string ErrorInput;

        public MissinNode(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            throw new NotImplementedException();
        }
    }
}

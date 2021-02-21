namespace Model
{
    [Node(NodeClassifyType.Decorator, "不运行")]
    public class NotRun : Node
    {
        public NotRun(NodeProto nodeProto): base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            return true;
        }
    }
}

namespace Model
{
    [Node(NodeClassifyType.Decorator, "取反")]
    public class Not : Node
    {
        public Not(NodeProto nodeProto): base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            if (children.Count > 0)
            {
                return !children[0].DoRun(behaviorTree, env);
            }
            return false;
        }
    }
}

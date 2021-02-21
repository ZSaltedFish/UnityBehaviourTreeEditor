namespace Model
{
    [Node(NodeClassifyType.Action, "阴影是否开放")]
    public class CameraShadowEnable : Node
    {
        public CameraShadowEnable(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            return true;
        }
    }
}

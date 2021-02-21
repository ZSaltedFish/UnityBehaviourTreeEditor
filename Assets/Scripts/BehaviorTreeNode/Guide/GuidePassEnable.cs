namespace Model
{
    [Node(NodeClassifyType.Action)]
    public class GuidePassEnable : Node
    {
        [NodeField("是否允许跳过步骤")]
        public bool Enable;
        public GuidePassEnable(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Game.EventSystem.Run(EventIdType.GuidePassEnable, Enable);
            return true;
        }
    }
}

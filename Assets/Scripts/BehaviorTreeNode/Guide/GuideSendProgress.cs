namespace Model
{
    [Node(NodeClassifyType.Action, "新手引导发送加载进度")]
    public class GuideSendProgress : Node
    {
        [NodeField("进度")]
        public int Progress;
        public GuideSendProgress(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Game.EventSystem.Run(EventIdType.GuideSendProgress, Progress);
            return true;
        }
    }
}

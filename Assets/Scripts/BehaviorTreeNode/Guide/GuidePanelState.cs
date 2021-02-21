namespace Model
{
    [Node(NodeClassifyType.Action, "设置引导界面文本")]
    public class ShowGuideText : Node
    {
        [NodeField("文本内容")]
        public string Text;

        public ShowGuideText(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Game.EventSystem.Run(EventIdType.ShowGuideText, Text);
            return true;
        }
    }
}

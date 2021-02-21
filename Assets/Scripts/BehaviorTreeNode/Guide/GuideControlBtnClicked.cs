namespace Model
{
    public enum UIClickBtnType
    {
        KickOut = 1,
        Shoot,
        Pass,
        FinalSkill = 5,
        Defance,
        Tackle,
        Marker,
        Direction,
        Switch
    }

    [Node(NodeClassifyType.Condition, "判断按钮是否触发")]
    public class GuideControlBtnClicked : Node
    {
        [NodeField("按钮类型")]
        public UIClickBtnType GuideType;

        public GuideControlBtnClicked(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            return true;
        }
    }
}

namespace Model
{
    [Node(NodeClassifyType.Action, "新手引导大招按钮特效")]
    public class GuideFinalEffect : Node
    {
        [NodeField("开关")]
        public bool IsOn;
        public GuideFinalEffect(NodeProto proto) : base(proto) { }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Game.EventSystem.Run(EventIdType.GuideFinalEffectNodeSwitch, IsOn);
            return true;
        }
    }
}

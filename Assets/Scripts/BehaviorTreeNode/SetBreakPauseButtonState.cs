namespace Model
{
    [Node(NodeClassifyType.Action, "设置跳过动画按钮状态")]
    public class SetBreakPauseButtonState : Node
    {
        [NodeField("显示状态", false)]
        public bool StateType;

        public SetBreakPauseButtonState(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //UIHelper.SetBreakPauseButtonState(StateType);
            return true;
        }
    }
}

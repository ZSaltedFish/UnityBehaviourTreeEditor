using System.Collections.Generic;

namespace Model
{
    [Node(NodeClassifyType.Action, "设置引导箭头状态")]
    public class SetGuideUIButtonTipsState : Node
    {
        [NodeField("按钮突破/推人")]
        public bool ButtonMoves;
        [NodeField("按钮射门/逼抢")]
        public bool ButtonShoot;
        [NodeField("按钮传球/铲球")]
        public bool ButtonPass;
        [NodeField("按钮，大招")]
        public bool ButtonFinalMoves;
        [NodeField("方向舵")]
        public bool ButtonArrow;
        [NodeField("面板展示状态")]
        public bool PanelShow;
        [NodeField("弹出内容")]
        public string PopupText;
        [NodeField("禁用面板跳过按钮")]
        public bool DisabledJumpButton;

        public SetGuideUIButtonTipsState(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //List<bool> bools = new List<bool>()
            //{
            //    ButtonMoves,
            //    ButtonShoot,
            //    ButtonPass,
            //    ButtonFinalMoves,
            //    ButtonArrow,
            //    DisabledJumpButton
            //};

            //Game.EventSystem.Run(EventIdType.ShowGuideTextPanelWithTips, bools, PanelShow, PopupText);
            return true;
        }
    }
}

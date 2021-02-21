using System.Collections.Generic;

namespace Model
{
    [Node(NodeClassifyType.Action, "设置控制按钮UI的可用状态")]
    public class SetControlUIState : Node
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

        public SetControlUIState(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            List<bool> bools = new List<bool>()
            {
                ButtonMoves,
                ButtonShoot,
                ButtonPass,
                ButtonFinalMoves,
                ButtonArrow
            };

            //Game.EventSystem.Run(EventIdType.ControlUIState, bools);
            return true;
        }
    }
}

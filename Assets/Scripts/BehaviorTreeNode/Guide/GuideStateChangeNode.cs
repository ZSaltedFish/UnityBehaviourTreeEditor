using System.Collections.Generic;

namespace Model
{
    [Node(NodeClassifyType.Action, "新手引导显示状态切换面板")]
    public class GuideStateChangeNode : Node
    {
        [NodeField("按钮提示")]
        public bool State;
        [NodeField("必杀技提示")]
        public bool FinalSkillTips;

        public GuideStateChangeNode(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //List<bool> bools = new List<bool>()
            //{
            //    State, FinalSkillTips
            //};
            //Game.EventSystem.Run(EventIdType.GuideStateChange, bools);
            return true;
        }
    }
}

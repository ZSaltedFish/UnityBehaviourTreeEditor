namespace Model
{
    [Node(NodeClassifyType.Action, "是否启用技能按钮")]
    public class SetSkillBtnEnable : Node
    {
        [NodeField("启用技能", true)]
        public bool BSkillEnabled;

		public SetSkillBtnEnable(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Game.EventSystem.Run(EventIdType.ChangeSkillBtnEnable, BSkillEnabled);
            return true;
        }
    }
}

namespace Model
{
    [Node(NodeClassifyType.Action, "传球数据输出")]
    public class PassDataOutput : Node
    {
        [NodeInput("技能输入", typeof(Spell))]
        public string SpellName;
        [NodeOutput("前摇时间", typeof(float))]
        public string ShakingTime;
        public PassDataOutput(NodeProto nodeProto): base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Spell spell = env.Get<Spell>(SpellName);
            //UnitDataComponent dataComp = spell.Caster.GetComponent<UnitDataComponent>();
            //dataComp.CommondPoint = dataComp.MoveDirection.normalized * 5 + spell.Caster.Position;
            //env.Add(ShakingTime, 0.5f);
            return true;
        }
    }
}

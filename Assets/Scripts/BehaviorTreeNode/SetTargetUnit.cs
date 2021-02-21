namespace Model
{
	public enum BindPointType
	{
		bone_Common,
		AttackPoint,
		bone_football,
		bone_head,
		bone_Waist,
		bone_RightFoot,
		bone_LeftFoot,
		bone_SkillTips,
		bone_l_hand,
		bone_r_hand,
	}

	[Node(NodeClassifyType.Action, "设置目标Unit")]
    public class SetTargetUnit : Node
    {
		[NodeInput("设置unit", typeof(Unit))]
		public string SourceUnit;

	    [NodeInput("目标unit", typeof(Unit))]
		public string TargetUnit;

	    [NodeField("绑点类型")]
	    public BindPointType BindPointType;

		public SetTargetUnit(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	  //      Unit sourceUnit = env.Get<Unit>(this.SourceUnit);
	  //      if (sourceUnit == null)
	  //      {
		 //       Log.Error("set target unit sourceunit is null");
		 //       return false;
	  //      }
	  //      Unit targetUnit = env.Get<Unit>(this.TargetUnit);
	  //      if (targetUnit == null)
	  //      {
		 //       Log.Error("set target unit targetunit is null");
		 //       return false;
	  //      }
			//sourceUnit.GetComponent<TargetComponent>().SetBindPoint(targetUnit, this.BindPointType);
	        return true;
        }
    }
}

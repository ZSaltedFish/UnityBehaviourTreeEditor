﻿namespace Model
{
    [Node(NodeClassifyType.Action, "修改状态机参数")]
    public class AnimatorSetInt : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

		[NodeField("状态机参数")]
	    public string Name;

	    [NodeField("数值")]
	    public int Value;

		public AnimatorSetInt(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	  //      Unit unit = env.Get<Unit>(this.UnitKey);

			//unit.GetComponent<AnimatorComponent>().SetIntValue(this.Name, this.Value);

	        return true;
        }
    }
}

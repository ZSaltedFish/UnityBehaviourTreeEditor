using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "计算转向完成后足球的位置设置给football")]
    public class SetFootballSpellTargetPos : Node
    {
	    [NodeInput("Spell", typeof(Spell))]
	    public string SpellKey;

		[NodeField("Distance", typeof(float))]
	    public float Distance;

		public SetFootballSpellTargetPos(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Spell spell = env.Get<Spell>(this.SpellKey);

	        //Unit unit = spell.Caster;
	        //Quaternion rotation = unit.GetComponent<MotorComponent>().GetFinalRotation();
	        //Vector3 v = PositionHelper.GetQuaternionToVector3(unit.Position, rotation, this.Distance);
	        //v.y = 0.15f;
	        //Unit football = FootBallHelper.GetFootBall();
	        //football.AddComponent<FootBallSpellPathTargetComponent>().TargetPos = v;
			
			return true;
        }
    }
}

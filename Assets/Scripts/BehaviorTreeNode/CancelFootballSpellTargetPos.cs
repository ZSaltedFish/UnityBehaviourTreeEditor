
namespace Model
{
    [Node(NodeClassifyType.Action, "取消football spell path")]
    public class CancelFootballSpellTargetPos : Node
    {
		public CancelFootballSpellTargetPos(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //Unit football = FootBallHelper.GetFootBall();
	        //football.RemoveComponent<FootBallSpellPathTargetComponent>();
			
			return true;
        }
    }
}

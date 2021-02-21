namespace Model
{
    [Node(NodeClassifyType.Condition, "IsMyActor")]
    public class IsMyActor : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string UnitKey;

		public IsMyActor(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit unit = env.Get<Unit>(this.UnitKey);
            //return ActorHelper.MyActor().Id == unit.Actor.Id;
            return true;
        }
    }
}

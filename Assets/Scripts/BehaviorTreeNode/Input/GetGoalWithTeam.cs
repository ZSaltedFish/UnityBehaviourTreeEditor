namespace Model
{
    [Node(NodeClassifyType.DataTransform, "根据队伍获取球门")]
    public class GetGoalWithTeam : Node
    {
        [NodeField("是否我方", true)]
        public bool IsMyTeam;
        [NodeOutput("球门", typeof(Unit))]
        public string OutputName;

        public GetGoalWithTeam(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //int team = ActorHelper.MyActor().Team - 1;
            //team = IsMyTeam ? team : 1 - team;

            //Unit goal = MapObjectComponent.Instance.GetUnits(MapObjectType.Goal)[team];
            //env.Add(OutputName, goal);
            return true;
        }
    }
}

namespace Model
{
    [Node(NodeClassifyType.DataTransform, "获取当前控制球员")]
    public class GetCurControlUnit : Node
    {
        [NodeOutput("当前控制球员", typeof(Unit))]
        public string Output;

        public GetCurControlUnit(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //env.Add(Output, UnitHelper.GetMyUnit());
            return true;
        }
    }
}

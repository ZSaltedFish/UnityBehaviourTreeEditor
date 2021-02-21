namespace Model
{
    [Node(NodeClassifyType.Action, "只执行n次")]
    public class PassNTime : Node
    {
        [NodeField("Num")]
        public int Num = 1;

        public PassNTime(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            if(Num-- > 0)
            {
                return true;
            }
            return false;
        }
    }
}

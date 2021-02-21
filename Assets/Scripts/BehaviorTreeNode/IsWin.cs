namespace Model
{
    [Node(NodeClassifyType.Condition, "我方是否胜利者")]
    public class IsWin : Node
    {
        public IsWin(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //var comp = SceneHelper.Scene.GetComponent<GameStateComponent>();
            //if (comp == null)
            //{
            //    return false;
            //}
            //return comp.IsWin;
            return true;
        }
    }
}

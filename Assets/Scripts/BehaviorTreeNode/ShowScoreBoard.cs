namespace Model
{
    [Node(NodeClassifyType.Action, "显示计分板UI")]
    public class ShowScoreBoard : Node
    {
        public ShowScoreBoard(NodeProto node)
            :base(node)
        {

        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Game.EventSystem.Run(EventIdType.ShowScoreBoardUI);
            return true;
        }
    }
}

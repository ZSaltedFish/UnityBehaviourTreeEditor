namespace Model
{
    [Node(NodeClassifyType.Root, "游戏场景事件统一根节点")]
    public class GameSceneEventRoot : Node
    {
        public GameSceneEventRoot(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            foreach (Node node in children)
            {
                node.DoRun(behaviorTree, env);
            }
            return true;
        }
    }
}

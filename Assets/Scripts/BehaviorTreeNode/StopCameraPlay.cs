namespace Model
{
    [Node(NodeClassifyType.Action, "停止镜头动画")]
    public class StopCameraPlay : Node
    {
        public StopCameraPlay(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //CameraTimeLineComponent comp = Game.Scene.Get(SceneType.Map.ToString())?.GetComponent<CameraTimeLineComponent>();
            //comp?.ClearAll();
            return true;
        }
    }
}

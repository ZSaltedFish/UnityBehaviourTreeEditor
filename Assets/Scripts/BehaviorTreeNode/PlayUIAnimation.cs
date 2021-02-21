using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "播放UI动画")]
    public class PlayUIAnimation : Node
    {
        [NodeField("动画数组")]
        public GameObject[] Animations;

        public PlayUIAnimation(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //foreach (GameObject go in Animations)
            //{
            //    if (go == null)
            //    {
            //        Log.Error($"行为树：{behaviorTree.Discription}({Id})意图创建一个空UI动画");
            //        continue;
            //    }
            //    Game.EventSystem.Run(EventIdType.PlayUIAnimation, go);
            //}
            return true;
        }
    }
}

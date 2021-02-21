using System;
using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "摄像机播放镜头动画")]
    public class CameraPlayAnimation : Node
    {
        [NodeField("动画数据")]
        public GameObject Animation;
        [NodeField("播放时长(毫秒)")]
        public long PlayTime;

        public CameraPlayAnimation(NodeProto p) : base(p) { }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Play();
            return true;
        }
    }
}

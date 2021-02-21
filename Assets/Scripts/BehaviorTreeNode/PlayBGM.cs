using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "播放BGM")]
    public class PlayBGM : Node
    {
        [NodeField("声音大小")]
        public float Volume = 1;
        [NodeField("Bgm")]
        public AudioClip BgmClip;

        public PlayBGM(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //AudioComponent.Instance.PlayBgm(BgmClip, Volume);
            return true;
        }
    }
}

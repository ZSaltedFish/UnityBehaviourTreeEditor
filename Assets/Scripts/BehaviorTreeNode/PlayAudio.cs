using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "播放声音")]
    public class PlayAudio : Node
    {
        [NodeField("AudioClip")]
        public AudioClip AudioClip;

	    [NodeField("Time")]
	    public long Time;

	    [NodeField("Volume")]
	    public float Volume;

		public PlayAudio(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        long time = this.Time;
	        if (time == 0)
	        {
		        time = (long) (this.AudioClip.length * 1000);
	        }
			//Game.Scene.GetComponent<AudioComponent>().PlayAudio(this.AudioClip, time/*, Volume*/);
            return true;
        }
    }
}

using System;
using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "振动手机")]
    public class Vibrate : Node
    {
	    [NodeField("时长,单位毫秒")]
		public int Time;

		public Vibrate(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        //DoVibrate(this.Time);
	        return true;
        }

	  //  private static async void DoVibrate(int time)
	  //  {
		 //   try
		 //   {
			//    float t = time;
			//    while (true)
			//    {
			//	    if (t <= 0)
			//	    {
			//		    break;
			//	    }
			//	    CommonHelper.Vibrate();
			//	    await Game.Scene.GetComponent<TimerComponent>().WaitAsync(500);
			//	    t -= 500;
			//    }
			//}
		 //   catch (Exception e)
		 //   {
			//	Log.Error(e);
		 //   }
	  //  }
    }
}

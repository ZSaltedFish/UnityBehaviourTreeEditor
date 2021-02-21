using UnityEngine;
using System;

namespace Model
{
    [Node(NodeClassifyType.Action, "TIMELINE返回到主摄像机")]
    public class TimeLineToMainCamera : Node
    {

        [NodeField("第一段位移X(是则使用Unit位置)")]
        public bool UseUnitX;
        [NodeField("第一段位移X")]
        public float ChangeX;
        [NodeField("第一段位移Y(是则使用Unit位置)")]
        public bool UseUnitY;
        [NodeField("第一段位移Y")]
        public float ChangeY;
        [NodeField("第一段位移Z(是则使用Unit位置)")]
        public bool UseUnitZ;
        [NodeField("第一段位移Z")]
        public float ChangeZ;

        [NodeOutput("移动时长", typeof(int))]
        public string TotalTime;

        
        public TimeLineToMainCamera(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //this.DelayRun(behaviorTree, env);

            //env.Add(TotalTime, ActTime1 + ActTime2);
            return true;
        }
    }
}

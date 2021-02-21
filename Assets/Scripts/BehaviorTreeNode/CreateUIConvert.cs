using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "创建一个渐入或者淡出的遮罩")]
    public class CreateUIConvert : Node
    {
        [NodeField("淡入淡出时长(ms)")]
        public long Time;

        [NodeField("淡入是True，淡出是False")]
        public bool IsIn;

        [NodeField("淡入淡出颜色")]
        public Color ConvertColor;

        public CreateUIConvert(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            float time = Time / 1000f;
            //Game.EventSystem.Run(EventIdType.SetUIConvertEvent, IsIn, time, ConvertColor);
            return true;
        }
    }
}

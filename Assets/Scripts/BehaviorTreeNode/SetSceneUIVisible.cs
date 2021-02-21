using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "设置场内UI的可见性")]
    public class SetSceneUIVisible : Node
    {
        [NodeField("场内UI可见性")]
        public bool Visible;

        public SetSceneUIVisible(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Game.EventSystem.Run(EventIdType.SceneUIType, Visible);
            return true;
        }
    }
}

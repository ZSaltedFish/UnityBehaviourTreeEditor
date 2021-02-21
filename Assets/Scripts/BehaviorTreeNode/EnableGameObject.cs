using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "开启或者关闭gameobject")]
    public class EnableGameObject : Node
    {
        [NodeInput("GameObject", typeof (GameObject))]
        public string GameObject;

        [NodeField("isEnable")]
        public bool Value;

        public EnableGameObject(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            UnityEngine.GameObject gameObject = env.Get<GameObject>(this.GameObject);
            gameObject.SetActive(this.Value);
            return true;
        }
    }
}

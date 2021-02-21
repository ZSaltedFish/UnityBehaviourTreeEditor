using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "开启或者关闭gameobject,计数")]
    public class EnableGameObjectByCount : Node
    {
        [NodeInput("GameObject", typeof (GameObject))]
        public string GameObject;

        [NodeField("isEnable")]
        public bool Value;

        public EnableGameObjectByCount(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //GameObject gameObject = env.Get<GameObject>(this.GameObject);
            //ActiveCount activeCount = gameObject.GetComponent<ActiveCount>();
            //if (activeCount == null)
            //{
            //    activeCount = gameObject.AddComponent<ActiveCount>();
            //}
            //activeCount.SetActive(this.Value);
            return true;
        }
    }
}

using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "remove GameObject")]
    public class RemoveGameObject : Node
    {
        [NodeInput("GameObject", typeof(GameObject))]
	    public string ObjKey;
        

        public RemoveGameObject(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            GameObject unit = env.Get<GameObject>(ObjKey);
            if(unit != null)
            {
                GameObject.Destroy(unit);
            }
            return true;
        }
    }
}

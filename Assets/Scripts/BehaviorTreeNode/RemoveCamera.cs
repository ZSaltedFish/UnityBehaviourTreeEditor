using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "remove Camera")]
    public class RemoveCamera : Node
    {
        [NodeInput("GameObject", typeof(Camera))]
	    public string ObjKey;
        

        public RemoveCamera(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            Camera unit = env.Get<Camera>(ObjKey);
            if(unit != null)
            {
                GameObject.Destroy(unit.gameObject);
            }
            return true;
        }
    }
}

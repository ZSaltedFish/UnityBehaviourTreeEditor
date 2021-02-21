using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "调整Scale")]
    public class GameObjectScale : Node
    {
	    [NodeInput("GameObject", typeof(GameObject))]
	    public string GameObject;
	    
	    [NodeInput("XValue", typeof(float))]
	    public string XValue;
	    
	    [NodeInput("YValue", typeof(float))]
	    public string YValue;
	    
	    [NodeInput("ZValue", typeof(float))]
	    public string ZValue;

		public GameObjectScale(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	  //      GameObject go = env.Get<GameObject>(this.GameObject);
	  //      float xvalue = env.Get<float>(this.XValue);
	  //      float yvalue = env.Get<float>(this.YValue);
	  //      float zvalue = env.Get<float>(this.ZValue);
	  //      Vector3 scale = go.GetComponent<Scale>().Origin;
			//scale.x += xvalue;
			//scale.y += yvalue;
			//scale.z += zvalue;
	  //      go.transform.localScale = scale;
			return true;
        }
    }
}

using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "获取距离")]
    public class Distance : Node
    {
	    [NodeInput("A点", typeof(Vector3))]
	    public string AKey;

	    [NodeInput("B点", typeof(Vector3))]
		public string BKey;

	    [NodeOutput("距离", typeof(float))]
		public string ValueKey;

		public Distance(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            Vector3 a = env.Get<Vector3>(this.AKey);
            Vector3 b = env.Get<Vector3>(this.BKey);
	        env.Add(this.ValueKey, Vector3.Distance(a, b));
	        return true;
        }
    }
}

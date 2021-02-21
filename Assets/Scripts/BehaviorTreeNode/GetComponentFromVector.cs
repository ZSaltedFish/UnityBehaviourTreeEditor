using UnityEngine;

namespace Model
{
	public enum VType
	{
		X,
		Y,
		Z,
	}
	
    [Node(NodeClassifyType.Condition, "获取向量分量")]
    public class GetComponentFromVector : Node
    {
	    [NodeInput("向量", typeof(Vector3))]
	    public string Vector3Key;
	    
	    [NodeField("哪个分量")]
	    public VType VType;
	    
	    [NodeOutput("输出", typeof(float))]
	    public string V;

		public GetComponentFromVector(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	        Vector3 v3 = env.Get<Vector3>(this.Vector3Key);

	        float v = 0;
	        switch (VType)
	        {
				case VType.X:
					v = v3.x;
					break;
				case VType.Y:
					v = v3.y;
					break;
				case VType.Z:
					v = v3.z;
					break;
	        }
	        env.Add(this.V, v);
			return true;
        }
    }
}

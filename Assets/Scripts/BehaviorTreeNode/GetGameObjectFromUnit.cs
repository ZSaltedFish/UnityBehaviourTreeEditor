using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "根据key,获取GameObject,输入key")]
    public class GetGameObjectFromUnit : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string Unit;

		[NodeField("key")]
	    public string Key;

	    [NodeOutput("GameObject", typeof(GameObject))]
	    public string GameObject;

		public GetGameObjectFromUnit(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	  //      Unit unit = env.Get<Unit>(this.Unit);
	  //      GameObject go = unit.GameObject.Get<GameObject>(this.Key);
			//env.Add(this.GameObject, go);
			return true;
        }
    }
}

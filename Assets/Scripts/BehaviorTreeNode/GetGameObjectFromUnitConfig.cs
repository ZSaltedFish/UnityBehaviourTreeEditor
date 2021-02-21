using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "根据key,UnitConfig获取,输入key")]
    public class GetGameObjectFromUnitConfig : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string Unit;

		[NodeField("key")]
	    public string Key;

	    [NodeOutput("GameObject", typeof(GameObject))]
	    public string GameObject;

		public GetGameObjectFromUnitConfig(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	  //      Unit unit = env.Get<Unit>(this.Unit);
	  //      GameObject go = unit.Config.Get<GameObject>(this.Key);
			//env.Add(this.GameObject, go);
			return true;
        }
    }
}

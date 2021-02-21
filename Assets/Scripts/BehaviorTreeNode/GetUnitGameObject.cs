using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Condition, "获取Unit的GameObject")]
    public class GetUnitGameObject : Node
    {
	    [NodeInput("Unit", typeof(Unit))]
	    public string Unit;

	    [NodeOutput("GameObject", typeof(GameObject))]
	    public string GameObject;

		public GetUnitGameObject(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	  //      Unit unit = env.Get<Unit>(this.Unit);
			//env.Add(this.GameObject, unit.GameObject);
			return true;
        }
    }
}

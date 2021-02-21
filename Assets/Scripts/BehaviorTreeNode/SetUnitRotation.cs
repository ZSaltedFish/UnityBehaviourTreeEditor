using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "设定单位的朝向")]
    public class SetUnitRotation : Node
    {
        [NodeInput("单位id", typeof(Unit))]
        public string UnitKey;

	    [NodeInput("方向", typeof(Vector3))]
	    public string DirKey;

		public SetUnitRotation(NodeProto proto)
            :base(proto)
        {

        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
	  //      Unit unit = env.Get<Unit>(this.UnitKey);
	  //      Vector3 dir = env.Get<Vector3>(this.DirKey);
	  //      Vector3 targetPos = unit.Position + dir;
			//unit.GameObject.transform.LookAt(targetPos);
	        return true;
        }
    }
}

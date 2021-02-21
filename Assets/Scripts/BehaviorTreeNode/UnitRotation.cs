namespace Model
{
    [Node(NodeClassifyType.Action, "设定单位的朝向")]
    public class UnitRotation : Node
    {
        [NodeInput("单位id", typeof(Unit))]
        public string Unit;
        
        public UnitRotation(NodeProto proto)
            :base(proto)
        {

        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
      //      Unit unit = env.Get<Unit>(this.Unit);
            
      //      if (unit == null)
      //      {
      //          return false;
      //      }
      //      TargetComponent targetComponent = unit.GetComponent<TargetComponent>();
      //      if (targetComponent == null)
      //      {
      //          return false;
      //      }
      //      Unit target = targetComponent.Target;
		    //if (target == null)
		    //{
			   // return false;
		    //}
      //      unit.GameObject.transform.rotation = target.GameObject.transform.rotation;
            return true;
        }
    }
}

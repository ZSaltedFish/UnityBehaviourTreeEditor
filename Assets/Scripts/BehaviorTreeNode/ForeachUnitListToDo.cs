using System.Collections.Generic;

namespace Model
{
    [Node(NodeClassifyType.Decorator, "为队列中每个Unit做其子树的内容")]
    public class ForeachUnitListToDo : Node
    {
        [NodeInput("单位队列", typeof(List<Unit>))]
        public string ListName;
        [NodeOutput("单位输出", typeof(Unit))]
        public string UnitName;
        public ForeachUnitListToDo(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            List<Unit> units = env.Get<List<Unit>>(ListName);
            foreach (Unit unit in units)
            {
                env.Add(UnitName, unit);
                foreach (Node node in children)
                {
                    node.DoRun(behaviorTree, env);
                }
            }

            return true;
        }
    }
}

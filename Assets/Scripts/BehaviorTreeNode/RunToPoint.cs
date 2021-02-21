using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "取球员的当前面向")]
    public class GetForwardDir : Node
    {
        [NodeInput("球员", typeof(Unit))]
        public string Player;

        [NodeOutput("面向", typeof(Vector3))]
        public string Dir;

        public GetForwardDir(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //Unit unit = env.Get<Unit>(Player);
            //env.Add(this.Dir, unit.GameObject.transform.forward);
            return true;
        }
    }
}

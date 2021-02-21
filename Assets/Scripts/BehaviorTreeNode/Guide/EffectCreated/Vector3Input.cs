using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.DataTransform, "输入一个Vector3")]
    public class Vector3Input : Node
    {
        [NodeField("位置X")]
        public float X;
        [NodeField("位置Y")]
        public float Y;
        [NodeField("位置Z")]
        public float Z;

        [NodeOutput("Vector3", typeof(Vector3), "DefaultVector3")]
        public string Output;
        public Vector3Input(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            env.Add(Output, new Vector3(X, Y, Z));
            return true;
        }
    }
}

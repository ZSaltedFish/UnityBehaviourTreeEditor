using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "输出一个Vector3")]
    public class Vector3Value : Node
    {
        [NodeField("X")]
        public float X;
        
        [NodeField("Y")]
        public float Y;
        
        [NodeField("Z")]
        public float Z;

        [NodeOutput("Vector3", typeof (Vector3))]
        public string Vector3Key;

        public Vector3Value(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            Vector3 v3 = new Vector3(this.X, this.Y, this.Z);
            
            env.Add(this.Vector3Key, v3);
            return true;
        }
    }
}

﻿using Model;
using Server;

namespace ServerTree
{
    [Node(NodeClassifyType.Condition, "是否被操作的球员")]
    public class IsControlled : Node
    {
        public IsControlled(NodeProto nodeProto) : base(nodeProto){}
        protected override bool Run(BehaviorTree behaviorTree, BTEnv env) { return true; }

        [NodeField("打开:传球目标返回false")]
        public bool CheckPass;

        [NodeInput("球员", typeof(Server.Unit))]
        public string Self;
    }
}
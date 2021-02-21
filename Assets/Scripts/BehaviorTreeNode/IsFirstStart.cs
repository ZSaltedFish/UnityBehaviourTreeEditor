using System;
using System.Collections.Generic;

namespace Model
{
    [Node(NodeClassifyType.Condition, "是否是第一次开球")]
    public class IsFirstStart : Node
    {
        public IsFirstStart(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //GameStateComponent game = SceneHelper.Scene.GetComponent<GameStateComponent>();
            //return game.IsFirst;
            return true;
        }
    }
}

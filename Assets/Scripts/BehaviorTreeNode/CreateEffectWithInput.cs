using System;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "创建特效")]
    public class CreateEffectWithInput : Node
    {
        [NodeInput("创建特效", typeof(GameObject))]
        public string EffectKey;

        [NodeInput("Unit", typeof(Unit))]
        public string Unit;

	    [NodeOutput("创建出来的特效组", typeof(List<Unit>))]
	    public string OutputEffects = "OutputEffect";

        public CreateEffectWithInput(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
         //   GameObject config = env.Get<GameObject>(this.EffectKey);
         //   List<Unit> effects = new List<Unit>();
	        //Unit unit = env.Get<Unit>(this.Unit);
         //   Unit effect = EffectFactory.Create(config, unit);
         //   effects.Add(effect);
         //   env.Add(this.OutputEffects, effects);
            return true;
        }
    }
}

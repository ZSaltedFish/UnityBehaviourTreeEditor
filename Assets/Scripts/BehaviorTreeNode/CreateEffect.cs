using System;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "创建特效")]
    public class CreateEffect : Node
    {
        [NodeField("创建特效")]
        public GameObject[] Effects;

        [NodeInput("Unit", typeof(Unit))]
        public string Unit;

	    [NodeOutput("创建出来的特效组", typeof(List<Unit>))]
	    public string OutputEffects = "OutputEffect";

        public CreateEffect(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
         //   List<Unit> effects = new List<Unit>();
	        //Unit unit = env.Get<Unit>(this.Unit);
         //   foreach (GameObject go in Effects)
         //   {
         //       Unit effect = EffectFactory.Create(go, unit);
         //       effects.Add(effect);
         //   }
         //   env.Add(OutputEffects, effects);
            return true;
        }
    }
}

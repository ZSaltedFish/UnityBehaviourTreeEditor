using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "创建特效带位置")]
    public class CreateEffectWithPosAndTurn : Node
    {
        [NodeField("创建特效")]
        public GameObject[] Effects;
        
        [NodeInput("Pos", typeof(Vector3))]
        public string Pos;
        
        [NodeInput("Quatation", typeof(Quaternion))]
        public string Quaternion;

	    [NodeOutput("创建出来的特效组", typeof(List<Unit>))]
	    public string OutputEffects = "OutputEffect";

        public CreateEffectWithPosAndTurn(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //List<Unit> effects = new List<Unit>();
            //Vector3 pos = env.Get<Vector3>(this.Pos);
            //Quaternion quaternion = env.Get<Quaternion>(this.Quaternion);
            
            //foreach (GameObject go in Effects)
            //{
            //    Unit effect = EffectFactory.Create(go, pos, quaternion);
            //    effects.Add(effect);
            //}
            //env.Add(OutputEffects, effects);
            return true;
        }
    }
}

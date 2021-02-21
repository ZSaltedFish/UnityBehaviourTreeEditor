using System;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "获取特效相机位置")]
    public class GetEffectCameraPos : Node
    {

        [NodeInput("创建出的特效(List<Unit>)", typeof(List<Unit>))]
        public string Unit;

	    [NodeOutput("相机世界位置，旋转，放大缩小比", typeof(List<Vector3>))]
	    public string OutputEffects = "OutputEffect";

        public GetEffectCameraPos(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //List<Vector3> objTrans = new List<Vector3>();
            //List<Unit> effects = env.Get<List<Unit>>(this.Unit);
            //if(effects != null)
            //{
            //    Unit firstUnit = effects[0];
            //    if(firstUnit != null)
            //    {
            //        ReferenceCollector rc = firstUnit.GameObject.GetComponent<ReferenceCollector>();
            //        GameObject cameraObj = rc.Get<GameObject>("Camera");
            //        if (cameraObj != null)
            //        {
            //            objTrans.Add(cameraObj.transform.position);
            //            objTrans.Add(cameraObj.transform.rotation.eulerAngles);
            //            objTrans.Add(cameraObj.transform.localScale);
            //        }
            //    }
            //}
            //env.Add(OutputEffects, objTrans);
            return true;
        }
    }
}

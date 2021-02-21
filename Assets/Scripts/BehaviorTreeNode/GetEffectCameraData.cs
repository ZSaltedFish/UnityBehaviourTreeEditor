using System;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    [Node(NodeClassifyType.Action, "获取特效相机位置")]
    public class GetEffectCameraData : Node
    {

        [NodeInput("创建出的特效(List<Unit>)", typeof(List<Unit>))]
        public string Unit;

	    [NodeOutput("相机世界位置，旋转，放大缩小比", typeof(List<Vector3>))]
	    public string OutputEffects = "OutputEffect";

        [NodeOutput("相机Fields", typeof(float))]
        public string OutputFields = "OutFields";

        public GetEffectCameraData(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //List<Vector3> objTrans = new List<Vector3>();
            //List<Unit> effects = env.Get<List<Unit>>(this.Unit);
            //float fields = 30f;
            //if (effects != null)
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
            //        fields = cameraObj.GetComponent<Camera>().fieldOfView;
            //    }
            //}
            //env.Add(OutputEffects, objTrans);
            //env.Add(OutputFields, fields);
            return true;
        }
    }
}

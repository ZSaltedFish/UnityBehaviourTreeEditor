using UnityEngine;
using System;
using System.Collections.Generic;

namespace Model
{
    [Node(NodeClassifyType.Action, "创建到指定方位")]
    public class CreateGameraInDest : Node
    {
        [NodeField("预制对象")]
        public GameObject TargetObj;

        [NodeInput("目标位置，旋转，缩放", typeof(List<Vector3>))]
		public string DestPost;

        [NodeInput("目标Fields", typeof(float))]
        public string DestFields;

        [NodeOutput("输出对象", typeof(Camera))]
        public string ObjKey;

        public CreateGameraInDest(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            //List<Vector3> dests = env.Get<List<Vector3>>(DestPost);
            //float destFields = env.Get<float>(DestFields);

            //if (TargetObj != null)
            //{
            //    //新建新物体
            //    GameObject cloneObj = UnityEngine.Object.Instantiate(TargetObj);
            //    GameObject mainCamera = new GameObject();

            //    cloneObj.transform.SetParent(mainCamera.transform.parent);

            //    //设定位置
            //    if (dests != null && dests.Count > 2)
            //    {
            //        cloneObj.transform.position = dests[0];
            //        cloneObj.transform.rotation = Quaternion.Euler(dests[1]);
            //        cloneObj.transform.localScale = dests[2];
            //    }

            //    Camera cloneCamera = cloneObj.GetComponent<Camera>();
            //    cloneCamera.fieldOfView = destFields;
            //    env.Add(this.ObjKey, cloneCamera);
            //}
            
            return true;
        }
    }
}

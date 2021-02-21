using UnityEngine;
using System;
using System.Collections.Generic;
namespace Model
{
    [Node(NodeClassifyType.Action, "创建到指定方位")]
    public class CreateGameObjectInDest : Node
    {
        [NodeField("预制对象")]
        public GameObject TargetObj;

        [NodeInput("目标位置，旋转，缩放", typeof(List<Vector3>))]
		public string DestPost;
        
        [NodeInput("父类对象", typeof(GameObject))]
        public string ParentKey;

        [NodeOutput("输出对象", typeof(GameObject))]
        public string ObjKey;

        public CreateGameObjectInDest(NodeProto nodeProto) : base(nodeProto)
        {
        }

        protected override bool Run(BehaviorTree behaviorTree, BTEnv env)
        {
            List<Vector3> dests = env.Get<List<Vector3>>(DestPost);
            GameObject parentObj = env.Get<GameObject>(ParentKey);
            if (TargetObj != null)
            {

                //新建新物体
                GameObject cloneObj = UnityEngine.Object.Instantiate(TargetObj);
                cloneObj.transform.SetParent(parentObj.transform);

                //设定位置
                if(dests != null && dests.Count > 2)
                {
                    cloneObj.transform.position = dests[0];
                    cloneObj.transform.rotation = Quaternion.Euler(dests[1]);
                    cloneObj.transform.localScale = dests[2];
                }
                env.Add(this.ObjKey, cloneObj);
            }
            
            return true;
        }
    }
}

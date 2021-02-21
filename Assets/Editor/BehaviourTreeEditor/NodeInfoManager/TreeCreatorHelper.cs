using System.IO;
using UnityEditor;
using UnityEngine;

namespace Model
{
    public static class TreeCreatorHelper
    {
        public static bool CreateNewTree(string exName, out string path)
        {
            path = EditorUtility.SaveFilePanel("创建行为树", EditorTreeConfigHelper.Instance.Config.ServersPath, "名字", exName);
            if (string.IsNullOrEmpty(path))
            {
                return false;
            }
            string name = BehaviourTreeJsonHelper.GetNameFromPath(path);
            NodeProto proto = new NodeProto()
            {
                Desc = name,
                Id = 10001
            };
            if (exName == "txt")
            {
                proto.Name = "ServerTreeNodeTest";
                using (StreamWriter wr = new StreamWriter(path))
                {
                    wr.Write(MongoHelper.ToJson(proto));
                }
            }
            else
            {
                proto.Name = typeof(SpellHitRoot).Name;
                GameObject goes = CreatePrefabWithNodeProto(proto);
                PrefabUtility.CreatePrefab(path, goes);
                UnityEngine.Object.DestroyImmediate(goes);
            }
            
            return true;
        }

        private static GameObject CreatePrefabWithNodeProto(NodeProto proto)
        {
            GameObject go = new GameObject(proto.Desc);
            BehaviorTreeConfig treeConfig = go.AddComponent<BehaviorTreeConfig>();
            GameObject noGo = new GameObject(proto.Name);
            BehaviorNodeConfig nodeConfig = noGo.AddComponent<BehaviorNodeConfig>();
            treeConfig.RootNodeConfig = nodeConfig;
            nodeConfig.id = proto.Id;
            nodeConfig.name = nodeConfig.name;
            nodeConfig.describe = proto.Desc;
            noGo.transform.SetParent(go.transform);
            return go;
        }
    }
}

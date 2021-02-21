using System.IO;

namespace Model
{
    public static class BehaviourTreeJsonHelper
    {
        public static void WriteToJson(BehaviorTreeConfig root, string namePath)
        {
            NodeProto proto = root.RootNodeProto;
            string path = namePath;
            using (StreamWriter writer = new StreamWriter(path))
            {
                string json = MongoHelper.ToJson(proto);
                writer.Write(json);
            }
        }

        public static string GetNameFromPath(string path)
        {
            int last = path.LastIndexOf('/');
            int point = path.IndexOf('.');
            return path.Substring(last + 1, point - last - 1);
        }
    }
}

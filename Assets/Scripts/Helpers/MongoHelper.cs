using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Model
{
    public static class MongoHelper
    {
        public static string ToJson(object obj)
        {
            DataContractJsonSerializer data = new DataContractJsonSerializer(obj.GetType());
            MemoryStream msObj = new MemoryStream();
            data.WriteObject(msObj, obj);
            msObj.Position = 0;
            StreamReader reader = new StreamReader(msObj, Encoding.UTF8);
            string json = reader.ReadToEnd();
            reader.Close();
            msObj.Close();
            return json;
        }

        public static T FromJson<T>(string str)
        {
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(str)))
            {
                DataContractJsonSerializer data = new DataContractJsonSerializer(typeof(T));
                T t = (T)data.ReadObject(ms);
                return t;
            }
        }
    }
}

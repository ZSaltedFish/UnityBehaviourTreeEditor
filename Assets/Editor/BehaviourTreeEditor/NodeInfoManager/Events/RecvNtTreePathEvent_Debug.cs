using System.Linq;

namespace Model
{
    //[Event(EventIdType.RecvNtTreePath)]
    public class RecvNtTreePathEvent_Debug// : AEvent<NtTreePath>
    {
        //public override void Run(NtTreePath message)
        //{
        //    if (RunTimeNodesManager.Instance == null)
        //    {
        //        return;
        //    }

        //    foreach (TreePathInfo path in message.PathInfos)
        //    {
        //        string treeName = path.TreeName.Utf8ToStr();
        //        int hashCode = treeName.GetHashCode();
        //        RunTimeNodesManager.Instance.AddDebugList(hashCode, path.NodeList.ToList());
        //    }
        //}
    }
}

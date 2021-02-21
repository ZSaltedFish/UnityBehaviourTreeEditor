using UnityEngine;

namespace Plant
{
    public interface ICollection
    {
        Vector3 GetNormal(Vector3 pos);
        bool IsIn(Vector3 pos);
    }
}

using System.Collections.Generic;
using UnityEngine;

namespace Plant
{
    public class TerrainDataModel : MonoBehaviour
    {
        private GameObject _sphere;

        private List<Collider> _colliders;

        public GameObject LookAt;

        public void Start()
        {
            _sphere = transform.Find("Sphere").gameObject;
            _colliders = new List<Collider>(GetComponentsInChildren<Collider>());
        }

        public void AdjustTransform(Transform target)
        {
            float height = ColliderHeight(target.transform.position);
            Vector3 setPos = target.position;
            setPos.y = height;
            target.position = setPos;
            Vector3 normal = Vector3.up;
            if (height > 0.001f)
            {
                Vector3 direDeep = setPos - _sphere.transform.position;
                normal = direDeep.normalized;
            }

            Vector3 forward = target.forward;
            Vector3 right = Vector3.Cross(forward, normal);
            Vector3 dire = Vector3.Cross(normal, right);
            target.LookAt(dire + setPos);

            float zAxis = Mathf.Acos(Vector3.Dot(normal, Vector3.up)) * Mathf.Rad2Deg;
            target.Rotate(0, 0, zAxis);
            LookAt.transform.position = dire + setPos;
        }

        private float ColliderHeight(Vector3 pos)
        {
            Vector3 origin = pos + 100 * Vector3.up;
            Ray ray = new Ray(origin, Vector3.down);
            float height = 0;
            foreach (Collider collider in _colliders)
            {
                if (collider.Raycast(ray, out RaycastHit hit, 1000))
                {
                    height = Mathf.Max(hit.point.y, height);
                }
            }
            return height;
        }
    }
}

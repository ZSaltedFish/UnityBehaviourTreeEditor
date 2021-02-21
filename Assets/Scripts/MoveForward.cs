using UnityEngine;

namespace Plant
{
    public class MoveForward : MonoBehaviour
    {
        public float Speed;
        public TerrainDataModel TerrainObject;

        public void Start()
        {
        }

        public void Update()
        {
            float delta = Speed * Time.deltaTime;
            transform.position += transform.forward * delta;
            TerrainObject.AdjustTransform(transform);
        }
    }
}

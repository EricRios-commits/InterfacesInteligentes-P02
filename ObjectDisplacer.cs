using System;
using UnityEngine;

namespace Sesión2
{
    [Serializable]
    public struct DisplacementSettings
    {
        public Transform transform;
        public Vector3 displacement;
    }

    public class ObjectDisplacer : MonoBehaviour
    {
        public DisplacementSettings[] objectsToDisplace;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                DisplaceObjects();
            }
        }

        private void DisplaceObjects()
        {
            foreach (var objectToDisplace in objectsToDisplace)
            {
                objectToDisplace.transform.position += objectToDisplace.displacement;
            }
        }
    }
}
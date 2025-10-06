using UnityEngine;

namespace Sesión2
{
    public class DistanceToObjectPrinter : MonoBehaviour
    {
        [SerializeField] private Transform[] targetObjects;
        private readonly int _frameInterval = 120;

        private void Update()
        {
            if (Time.frameCount % _frameInterval == 0)
            {
                PrintDistances();
            }
        }

        private void PrintDistances()
        {
            foreach (var target in targetObjects)
            {
                float distance = Vector3.Distance(transform.position, target.position);
                Debug.Log($"Distance from {name} to {target.name} is {distance}");
            }
        }
    }
}
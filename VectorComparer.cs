using UnityEngine;

namespace Sesión2
{
    public class VectorComparer : MonoBehaviour
    {
        public Vector3 firstVector = Vector3.up * 5f;
        public Vector3 secondVector = new(15f, 0, 0);
        private readonly int _frameInterval = 120;

        public float FirstVectorMagnitude;
        public float SecondVectorMagnitude;
        public float AngleBetweenVectors;
        public float DistanceBetweenVectors;
        public Vector3 HigherVector;
        public Vector3 ObjectPosition;

        private void Update()
        {
            if (Time.frameCount % _frameInterval == 0)
            {
                CalculateProperties();
                PrintText();
            }
        }

        private void CalculateProperties()
        {
            FirstVectorMagnitude = firstVector.magnitude;
            SecondVectorMagnitude = secondVector.magnitude;
            AngleBetweenVectors = Vector3.Angle(firstVector, secondVector);
            DistanceBetweenVectors = Vector3.Distance(firstVector, secondVector);
            HigherVector = firstVector.y > secondVector.y ? firstVector : secondVector;
            ObjectPosition = transform.position;
        }

        private void PrintText()
        {
            Debug.Log($"First vector: {firstVector}, magnitude: {FirstVectorMagnitude}");
            Debug.Log($"Second vector: {secondVector}, magnitude: {SecondVectorMagnitude}");
            Debug.Log($"Angle between vectors: {AngleBetweenVectors}");
            Debug.Log($"Distance between vectors: {DistanceBetweenVectors}");
            Debug.Log($"Higher vector: {HigherVector}");
            Debug.Log($"{name} is at {ObjectPosition}");
        }
    }
}

using UnityEngine;

namespace Sesión2
{
    public class RandomColorChanger : MonoBehaviour
    {
        [SerializeField] private float framesInterval = 120f;
        [SerializeField] private Color color;
        private Renderer _objectRenderer;
    
        void Start()
        {
            _objectRenderer = GetComponent<Renderer>();
            color = new (255, 255, 255);
            _objectRenderer.material.color = color;
        }

        void Update()
        {
            if (Time.frameCount % framesInterval == 0)
            {
                color = RandomColorInRandomPosition(color);
                _objectRenderer.material.color = color;
            }
        }

        private Color RandomColorInRandomPosition(Color originalColor)
        {
            int position = Random.Range(0, 3);
            float randomValue = Random.Range(0f, 1f);
            Color newColor = originalColor;
            switch (position)
            {
                case 0:
                    newColor.r = randomValue;
                    break;
                case 1:
                    newColor.g = randomValue;
                    break;
                case 2:
                    newColor.b = randomValue;
                    break;
            }
            return newColor;
        }
    }
}

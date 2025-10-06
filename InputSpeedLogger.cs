using UnityEngine;

namespace Sesión2
{
    public class InputSpeedLogger : MonoBehaviour
    {
        [SerializeField] private float speed;

        private void Update()
        {
            HandleInput();
        }

        private void HandleInput()
        {
            var horizontalInput = Input.GetAxis("HorizontalArrows");
            var verticalInput = Input.GetAxis("VerticalArrows");
            if (horizontalInput != 0)
            {
                string pressedKey = horizontalInput > 0 ? "right" : "left";
                Debug.Log($"{pressedKey} arrow key pressed, which would make the object move at speed {speed * horizontalInput}");
            }
            if (Input.GetAxis("Vertical") != 0)
            {
                string pressedKey = verticalInput > 0 ? "up" : "down";
                Debug.Log($"{pressedKey} arrow key pressed, which would make the object move at speed {speed * verticalInput}");
            }
        }
    }
}

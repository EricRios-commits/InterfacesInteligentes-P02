using UnityEngine;

namespace Sesión2
{
    public class InputMovedObject : MonoBehaviour
    {
        [SerializeField] private string horizontalAxisName = "HorizontalArrows";
        [SerializeField] private string verticalAxisName = "VerticalArrows";
        [SerializeField] private float speed = 2f;

        private void Update()
        {
            HandleInput();
        }
        
        private void HandleInput()
        {
            var horizontalInput = Input.GetAxis(horizontalAxisName);
            var verticalInput = Input.GetAxis(verticalAxisName);
            if (horizontalInput != 0 || verticalInput != 0)
            {
                Vector3 moveDirection = new(horizontalInput, 0, verticalInput);
                transform.Translate(moveDirection * (speed * Time.deltaTime));
            }
        }
    }
}

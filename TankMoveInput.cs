using UnityEngine;

namespace Sesión2
{
    public class TankMoveInput : MonoBehaviour
    {
        [SerializeField] private string horizontalAxisName = "HorizontalArrows";
        [SerializeField] private string verticalAxisName = "VerticalArrows";
        [SerializeField] private float speed = 2f;
        [SerializeField] private float rotateSpeed = 5f;

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
                transform.Rotate(0, horizontalInput * (speed * Time.deltaTime * rotateSpeed), 0);
                transform.Translate(transform.forward * (verticalInput * (speed * Time.deltaTime)), Space.World);
            }
        }

    }
}
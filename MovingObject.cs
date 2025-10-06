using UnityEngine;

namespace Sesión2
{
    public class MovingObject : MonoBehaviour
    {
        [SerializeField] private Vector3 moveDirection;
        [SerializeField] private float speed = 2f;

        private void Start()
        {
            transform.position = new (transform.position.x, 0, transform.position.z);
        }

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            transform.Translate(moveDirection * (speed * Time.deltaTime));
        }
    }
}

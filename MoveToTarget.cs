using UnityEngine;

namespace Sesión2
{
    public class MoveToTarget : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private float speed = 2f;
        
        private void Update()
        {
            Move();
        }
        
        private void Move()
        {
            if (target == null) return;
            Vector3 direction = (target.position - transform.position);
            direction.y = 0;
            direction.Normalize();
            transform.Translate(direction * (speed * Time.deltaTime), Space.World);
            transform.LookAt(target);
        }
    }
}
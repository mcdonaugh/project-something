using UnityEngine;

namespace ProjectSomething.Controllers
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private float _depth = 5;
        [SerializeField] private float _height = 0;
        private ActorController _actorController;
        private Transform _gimbalPosition;

        public void SetActorController(ActorController actorController)
        {
            _actorController = actorController;
            _gimbalPosition = actorController.transform.GetChild(0);
        }

        private void LateUpdate()
        {
            transform.position = new Vector3(_gimbalPosition.position.x, _actorController.transform.position.y + _height, _gimbalPosition.position.z);
            transform.LookAt(_actorController.transform);
            float mouseXPosition = Input.GetAxis("Mouse X");
            Debug.Log(mouseXPosition);
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawSphere(transform.position, 1);
        }
    }
}
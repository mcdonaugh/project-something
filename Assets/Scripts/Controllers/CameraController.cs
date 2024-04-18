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

            _gimbalPosition.localPosition = new Vector3(
            _gimbalPosition.localPosition.x,
            _gimbalPosition.localPosition.y + _height,
            _gimbalPosition.localPosition.z + _depth);
        }

        private void LateUpdate()
        {
            transform.position = new Vector3(_gimbalPosition.position.x, _gimbalPosition.position.y, _gimbalPosition.position.z);
            transform.LookAt(_actorController.transform);
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawSphere(transform.position, 1);
        }
    }
}
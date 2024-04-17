using UnityEngine;

namespace ProjectSomething.Controllers
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private float _depth = 5;
        [SerializeField] private float _height = 0;
        private ActorController _actorController;

        public void SetActorController(ActorController actorController)
        {
            _actorController = actorController;
        }

        private void LateUpdate()
        {
            transform.position = new Vector3(_actorController.transform.position.x, _actorController.transform.position.y + _height, _actorController.transform.position.z - _depth);
            transform.LookAt(_actorController.transform);
        }
    }
}
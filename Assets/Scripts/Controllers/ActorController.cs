using UnityEngine;
using ProjectSomething.Interfaces;

namespace ProjectSomething.Controllers
{
    public class ActorController : MonoBehaviour
    {
        private IInput _input;
        private ActorData _actorData;
        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
        private void FixedUpdate()
        {
            MovePosition(_input.GetInput());
        }

        public void SetInputController(IInput input)
        {
            _input = input;
        }

        public void SetActorData(ActorData actorData)
        {
            _actorData = actorData;
        }

        private void MovePosition(Vector2 input)
        {
            _rigidbody.MovePosition(_rigidbody.position + new Vector3(input.x, 0, input.y) * _actorData.MoveSpeed * Time.fixedDeltaTime);
        }
    }
}
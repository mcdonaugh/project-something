using UnityEngine;
using ProjectSomething.Interfaces;

namespace ProjectSomething.Controllers
{
    public class ActorController : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
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
            MoveRotation(_input.GetInput());
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
            _rigidbody.MovePosition(_rigidbody.position + (transform.forward * input.y + transform.right * input.x).normalized * _actorData.MoveSpeed * Time.fixedDeltaTime);
            float i = Mathf.Max(Mathf.Abs(input.x),Mathf.Abs(input.y));
            _animator.SetFloat("Input", i);
            Debug.Log(i);
        }

        private void MoveRotation(Vector2 input)
        {
            Vector3 rotation = new Vector3(0, transform.eulerAngles.y + Input.GetAxis("Mouse X") * _actorData.RotationSpeed, 0);
            Quaternion quaternion = Quaternion.Euler(rotation);
            _rigidbody.MoveRotation(quaternion);
        }
    }
}
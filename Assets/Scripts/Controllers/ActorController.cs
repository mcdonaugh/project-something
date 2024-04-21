using UnityEngine;
using ProjectSomething.Interfaces;

namespace ProjectSomething.Controllers
{
    public class ActorController : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        protected IInput _input;
        private ActorData _actorData;
        private Rigidbody _rigidbody;
        private string _currentAnimation = "";

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            MovePosition(_input.GetAxisInput());
            MoveRotation(_input.GetAxisInput());
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

            if (input.y > 0)
            {
                ChangeAnimation("Move Forward");
            }
            else if (input.y < 0)
            {
                ChangeAnimation("Move Backward");
            }
            else if (input.x > 0)
            {
                ChangeAnimation("Move Right");
            }
            else if (input.x < 0)
            {
                ChangeAnimation("Move Left");
            }
            else
            {
                ChangeAnimation("Idle");
            }
        }

        private void MoveRotation(Vector2 input)
        {
            Vector3 rotation = new Vector3(0, transform.eulerAngles.y + Input.GetAxis("Mouse X") * _actorData.RotationSpeed, 0);
            Quaternion quaternion = Quaternion.Euler(rotation);
            _rigidbody.MoveRotation(quaternion);
        }
        
        protected void ChangeAnimation(string animation, float crossfade = 0.2f)
        {
            if (_currentAnimation != animation)
            {   
                _currentAnimation = animation;
                _animator.CrossFade(animation, crossfade);
            }
        }
    }
}
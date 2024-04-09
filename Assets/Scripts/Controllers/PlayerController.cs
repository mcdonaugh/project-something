using UnityEngine;
using ProjectSomething.Interfaces;

namespace ProjectSomething.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float _playerSpeed = 1;
        private IInput _input;

        private void Update()
        {
            MovePlayer(_input.GetInput());
        }

        public void SetInputController(IInput input)
        {
            _input = input;
        }

        private void MovePlayer(Vector2 input)
        {
            transform.position += new Vector3(input.x, 0, input.y) * _playerSpeed * Time.deltaTime;
        }
    }
}
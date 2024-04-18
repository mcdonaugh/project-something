using ProjectSomething.Player;
using UnityEngine;

namespace ProjectSomething.Controllers
{
    public class GameStateController : MonoBehaviour
    {
        private PlayerInputController _playerInputController;

        private void Start()
        {
            _playerInputController.DisableCursor();
        }

        public void SetPlayerInputController(PlayerInputController playerInputController)
        {
            _playerInputController = playerInputController;
        }
    }
}

using UnityEngine;
using ProjectSomething.Interfaces;

namespace ProjectSomething.Controllers
{
    public class PlayerInstallerController : MonoBehaviour
    {
        [SerializeField] private PlayerController _playerController;
        private PlayerInputController _playerInputController;
        private void Awake()
        {
            _playerInputController = new PlayerInputController();
            _playerController = Instantiate(_playerController, transform.position, Quaternion.identity);
            _playerController.SetInputController(_playerInputController);
        }
    }
}
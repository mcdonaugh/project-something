using UnityEngine;
using ProjectSomething.Interfaces;

namespace ProjectSomething.Controllers
{
    public class PlayerInstallerController : MonoBehaviour
    {
        [SerializeField] private ActorController _playerController;
        [SerializeField] private ActorData _playerData;
        [SerializeField] private CameraController _cameraController;
        [SerializeField] private GameStateController _gameStateController;
        private void Awake()
        {
            IInput playerController = new PlayerInputController();
            _playerController = Instantiate(_playerController, transform.position, Quaternion.identity);
            _playerController.SetInputController(playerController);
            _gameStateController.SetPlayerInputController((PlayerInputController)playerController);
            _playerController.SetActorData(_playerData);
            _cameraController.SetActorController(_playerController);
        }
    }
}
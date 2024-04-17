using UnityEngine;
using ProjectSomething.Interfaces;

namespace ProjectSomething.Controllers
{
    public class PlayerInstallerController : MonoBehaviour
    {
        [SerializeField] private ActorController _playerController;
        [SerializeField] private ActorData _playerData;
        private void Awake()
        {
            IInput playerController = new PlayerInputController();
            _playerController = Instantiate(_playerController, transform.position, Quaternion.identity);
            _playerController.SetInputController(playerController);
            _playerController.SetActorData(_playerData);
        }
    }
}
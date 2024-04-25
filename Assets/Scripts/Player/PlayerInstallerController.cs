using UnityEngine;
using ProjectSomething.Interfaces;
using ProjectSomething.Controllers;
using ProjectSomething.Data;

namespace ProjectSomething.Player
{
    public class PlayerInstallerController : MonoBehaviour
    {
        [SerializeField] private ActorController _playerController;
        [SerializeField] private ActorData _playerData;
        [SerializeField] private CameraController _cameraController;
        [SerializeField] private GameStateController _gameStateController;
        [SerializeField] private PlayerSelectedActorAttributes _playerSelectedActorAttributes;
        [SerializeField] private ActorAttributesDatabase _actorAttributesDatabase;

        private void Awake()
        {
            IInput playerController = new PlayerInputController();
            _playerController = Instantiate(_playerController, transform.position, Quaternion.identity);
            _playerController.SetInputController(playerController);
            _gameStateController.SetPlayerInputController((PlayerInputController)playerController);
            _playerController.SetActorData(_playerData);
            _cameraController.SetActorController(_playerController);
            PlayerMeshLoader playerMeshLoader = new PlayerMeshLoader(_playerSelectedActorAttributes, _actorAttributesDatabase);
            playerMeshLoader.SetPlayerMeshes(_playerController.gameObject);
            playerMeshLoader.UpdatePlayerMesh();
        }
    }
}
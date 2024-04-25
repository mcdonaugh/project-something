using ProjectSomething.Data;
using UnityEngine;

namespace ProjectSomething.Player
{
    public class PlayerMeshLoader
    {
        private PlayerSelectedActorAttributes _playerSelectedActorAttributes;
        private ActorAttributesDatabase _actorAttributesDatabase;
        private MeshFilter _eyesMesh;
        private MeshFilter _hairMesh;
        private MeshFilter _headMesh;
        private SkinnedMeshRenderer _bodyMesh;

        public PlayerMeshLoader(PlayerSelectedActorAttributes playerSelectedActorAttributes, ActorAttributesDatabase actorAttributesDatabase)
        {
            _playerSelectedActorAttributes = playerSelectedActorAttributes;
            _actorAttributesDatabase = actorAttributesDatabase;
        }

        public void SetPlayerMeshes(GameObject player)
        {
            _eyesMesh = player.transform.Find("Character Model/root/pelvis/spine_01/spine_02/spine_03/neck_01/head/Eyes").GetComponent<MeshFilter>();
            _hairMesh = player.transform.Find("Character Model/root/pelvis/spine_01/spine_02/spine_03/neck_01/head/Hair").GetComponent<MeshFilter>();
            _headMesh = player.transform.Find("Character Model/root/pelvis/spine_01/spine_02/spine_03/neck_01/head/Face").GetComponent<MeshFilter>();
            _bodyMesh = player.transform.Find("Character Model/Body").GetComponent<SkinnedMeshRenderer>();

            Debug.Log(_hairMesh);
        }

        public void UpdatePlayerMesh()
        {
            _eyesMesh.mesh = _actorAttributesDatabase.EyesAttributesGroup.BodyTypeMeshes[_playerSelectedActorAttributes.EyesIndex];
            _hairMesh.mesh = _actorAttributesDatabase.HairAttributesGroup.BodyTypeMeshes[_playerSelectedActorAttributes.HairIndex];
            _headMesh.mesh = _actorAttributesDatabase.HeadAttributesGroup.BodyTypeMeshes[_playerSelectedActorAttributes.HeadIndex];
            _bodyMesh.sharedMesh = _actorAttributesDatabase.BodyAttributesGroup.BodyTypeMeshes[_playerSelectedActorAttributes.BodyIndex];
        }
    }
}
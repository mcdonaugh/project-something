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
            // _eyesMesh = player.transform.Find("Eyes").GetComponent<MeshFilter>();
            // _hairMesh = player.transform.Find("Hair").GetComponent<MeshFilter>();
            // _headMesh = player.transform.Find("Face").GetComponent<MeshFilter>();
            _bodyMesh = player.transform.Find("Character Model/Body").GetComponent<SkinnedMeshRenderer>();
        }

        public void UpdatePlayerMesh()
        {
            // _eyesMesh.mesh = _actorAttributesDatabase.EyesAttributesGroup[0].BodyTypeMeshes[_playerSelectedActorAttributes.EyesIndex];
            // _hairMesh.mesh = _actorAttributesDatabase.HairAttributesGroup[0].BodyTypeMeshes[_playerSelectedActorAttributes.HairIndex];
            // _headMesh.mesh = _actorAttributesDatabase.HeadAttributesGroup[0].BodyTypeMeshes[_playerSelectedActorAttributes.HeadIndex];
            // _bodyMesh.sharedMesh = _actorAttributesDatabase.BodyAttributesGroup[0].BodyTypeMeshes[_playerSelectedActorAttributes.BodyIndex];
            Debug.Log(_bodyMesh);
        }
    }
}
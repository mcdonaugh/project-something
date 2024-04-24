using ProjectSomething.Data;
using UnityEngine;

namespace ProjectSomething.Content.CharacterCreation
{
    public class CharacterCreationController : MonoBehaviour
    {
        [SerializeField] private GameObject _playerCustomizationModel;
        [SerializeField] private ActorAttributes _maleGenderAttributes;
        [SerializeField] private ActorAttributes _femaleGenderAttributes;
        [SerializeField] private ActorAttributesDatabase _maleActorAttributesDatabase;
        [SerializeField] private ActorAttributesDatabase _femaleActorAttributesDatabase;
        [SerializeField] private MeshFilter _eyeMesh;
        [SerializeField] private MeshFilter _hairMesh;
        [SerializeField] private MeshFilter _headMesh;
        [SerializeField] private SkinnedMeshRenderer _bodyMesh;
        private ActorAttributesDatabase _selectedActorAttributesDatabase = null;
        private int hairIndex = 0;
        
        private void Awake()
        {
            SetGenderMale();
        }

        public void SetGenderFemale()
        {
            _eyeMesh.mesh = _femaleGenderAttributes.BodyTypeMeshes[0];
            _hairMesh.mesh = _femaleGenderAttributes.BodyTypeMeshes[1];
            _headMesh.mesh = _femaleGenderAttributes.BodyTypeMeshes[2];
            _bodyMesh.sharedMesh = _femaleGenderAttributes.BodyTypeMeshes[3];

            _selectedActorAttributesDatabase = _femaleActorAttributesDatabase;
        }

        public void SetGenderMale()
        {
            _eyeMesh.mesh = _maleGenderAttributes.BodyTypeMeshes[0];
            _hairMesh.mesh = _maleGenderAttributes.BodyTypeMeshes[1];
            _headMesh.mesh = _maleGenderAttributes.BodyTypeMeshes[2];
            _bodyMesh.sharedMesh = _maleGenderAttributes.BodyTypeMeshes[3];

            _selectedActorAttributesDatabase = _maleActorAttributesDatabase;
        }

        public void RightButton()
        {
            if (hairIndex >= _selectedActorAttributesDatabase.ActorAttributesGroup[0].BodyTypeMeshes.Length - 1)
            {
                hairIndex = 0;
            }
            else
            {
                hairIndex++;
            }
            _hairMesh.mesh = _selectedActorAttributesDatabase.ActorAttributesGroup[0].BodyTypeMeshes[hairIndex];
        }

        public void LeftButton()
        {
            if (hairIndex <= 0)
            {
                hairIndex = _selectedActorAttributesDatabase.ActorAttributesGroup[0].BodyTypeMeshes.Length - 1;
            }
            else
            {
                hairIndex--;
            }
            _hairMesh.mesh = _selectedActorAttributesDatabase.ActorAttributesGroup[0].BodyTypeMeshes[hairIndex];
        }
    }
}
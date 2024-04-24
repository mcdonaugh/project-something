using ProjectSomething.Data;
using TMPro;
using UnityEngine;

namespace ProjectSomething.Content.CharacterCreation
{
    public class CharacterCreationController : MonoBehaviour
    {
        [SerializeField] private GameObject _playerCustomizationModel;
        [SerializeField] private ActorAttributesDatabase _ActorAttributesDatabase;
        [SerializeField] private ActorAttributesDatabase _selectedActorAttributesDatabase;
        [SerializeField] private MeshFilter _eyesMesh;
        [SerializeField] private MeshFilter _hairMesh;
        [SerializeField] private MeshFilter _headMesh;
        [SerializeField] private SkinnedMeshRenderer _bodyMesh;
        [SerializeField] private TMP_Text _hairIndexText;
        [SerializeField] private TMP_Text _eyesIndexText;
        [SerializeField] private TMP_Text _headIndexText;
        private int hairIndex = 0;
        private int eyesIndex = 0;
        private int headIndex = 0;
        private int bodyIndex = 0;
        
        private void Awake()
        {
            SetAppearancePreset0();
        }

        public void SetAppearancePreset0()
        {
            _hairMesh.mesh = _selectedActorAttributesDatabase.HairAttributesGroup[0].BodyTypeMeshes[1];
            _eyesMesh.mesh = _selectedActorAttributesDatabase.EyesAttributesGroup[0].BodyTypeMeshes[0];
            _headMesh.mesh = _selectedActorAttributesDatabase.HeadAttributesGroup[0].BodyTypeMeshes[0];
            _bodyMesh.sharedMesh = _selectedActorAttributesDatabase.BodyAttributesGroup[0].BodyTypeMeshes[0];
            
            UpdateIndexText();
        }

        public void SetAppearancePreset1()
        {
            _hairMesh.mesh = _selectedActorAttributesDatabase.HairAttributesGroup[0].BodyTypeMeshes[6];
            _eyesMesh.mesh = _selectedActorAttributesDatabase.EyesAttributesGroup[0].BodyTypeMeshes[1];
            _headMesh.mesh = _selectedActorAttributesDatabase.HeadAttributesGroup[0].BodyTypeMeshes[1];
            _bodyMesh.sharedMesh = _selectedActorAttributesDatabase.BodyAttributesGroup[0].BodyTypeMeshes[1];

            UpdateIndexText();
        }

        public void SetHairNext()
        {
            if (hairIndex >= _selectedActorAttributesDatabase.HairAttributesGroup[0].BodyTypeMeshes.Length - 1)
            {
                hairIndex = 0;
            }
            else
            {
                hairIndex++;
            }

            _hairMesh.mesh = _selectedActorAttributesDatabase.HairAttributesGroup[0].BodyTypeMeshes[hairIndex];

            UpdateIndexText();
        }

        public void SetHairPrev()
        {
            if (hairIndex <= 0)
            {
                hairIndex = _selectedActorAttributesDatabase.HairAttributesGroup[0].BodyTypeMeshes.Length - 1;
            }
            else
            {
                hairIndex--;
            }

            _hairMesh.mesh = _selectedActorAttributesDatabase.HairAttributesGroup[0].BodyTypeMeshes[hairIndex];

            UpdateIndexText();
        }

        public void SetEyesNext()
        {
            if (eyesIndex >= _selectedActorAttributesDatabase.EyesAttributesGroup[0].BodyTypeMeshes.Length - 1)
            {
                eyesIndex = 0;
            }
            else
            {
                eyesIndex++;
            }

            _eyesMesh.mesh = _selectedActorAttributesDatabase.EyesAttributesGroup[0].BodyTypeMeshes[eyesIndex];

            UpdateIndexText();
        }

        public void SetEyesPrev()
        {
            if (eyesIndex <= 0)
            {
                eyesIndex = _selectedActorAttributesDatabase.EyesAttributesGroup[0].BodyTypeMeshes.Length - 1;
            }
            else
            {
                eyesIndex--;
            }

            _eyesMesh.mesh = _selectedActorAttributesDatabase.EyesAttributesGroup[0].BodyTypeMeshes[eyesIndex];

            UpdateIndexText();
        }

        public void SetHeadNext()
        {
            if (headIndex >= _selectedActorAttributesDatabase.HeadAttributesGroup[0].BodyTypeMeshes.Length - 1)
            {
                headIndex = 0;
            }
            else
            {
                headIndex++;
            }

            _headMesh.mesh = _selectedActorAttributesDatabase.HeadAttributesGroup[0].BodyTypeMeshes[headIndex];

            UpdateIndexText();
        }

        public void SetHeadPrev()
        {
            if (headIndex <= 0)
            {
                headIndex = _selectedActorAttributesDatabase.HeadAttributesGroup[0].BodyTypeMeshes.Length - 1;
            }
            else
            {
                headIndex--;
            }

            _headMesh.mesh = _selectedActorAttributesDatabase.HeadAttributesGroup[0].BodyTypeMeshes[headIndex];

            UpdateIndexText();
        }

        public void UpdateIndexText()
        {
            _eyesIndexText.SetText(eyesIndex.ToString());
            _hairIndexText.SetText(hairIndex.ToString());
            _headIndexText.SetText(headIndex.ToString());
        }
    }
}
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
        [SerializeField] private GameObject _eyeBrows;
        [SerializeField] private TMP_Text _hairIndexText;
        [SerializeField] private TMP_Text _eyesIndexText;
        [SerializeField] private TMP_Text _headIndexText;
        private int _hairIndex = 0;
        private int _eyesIndex = 0;
        private int _headIndex = 0;
        private int _bodyIndex = 0;
        
        private void Awake()
        {
            SetAppearancePreset0();
        }

        public void SetAppearancePreset0()
        {
            _hairIndex = 1;
            _eyesIndex = 0;
            _headIndex = 0;
            _bodyIndex = 0;
            SetAppearance();
            UpdateIndexText();
        }

        public void SetAppearancePreset1()
        {
            _hairIndex = 6;
            _eyesIndex = 1;
            _headIndex = 1;
            _bodyIndex = 1;
            SetAppearance();
            UpdateIndexText();
        }

        public void SetHairNext()
        {
            if (_hairIndex >= _selectedActorAttributesDatabase.HairAttributesGroup[0].BodyTypeMeshes.Length - 1)
            {
                _hairIndex = 0;
            }
            else
            {
                _hairIndex++;
            }

            SetAppearance();
            UpdateIndexText();
        }

        public void SetHairPrev()
        {
            if (_hairIndex <= 0)
            {
                _hairIndex = _selectedActorAttributesDatabase.HairAttributesGroup[0].BodyTypeMeshes.Length - 1;
            }
            else
            {
                _hairIndex--;
            }

            SetAppearance();
            UpdateIndexText();
        }

        public void SetEyesNext()
        {
            if (_eyesIndex >= _selectedActorAttributesDatabase.EyesAttributesGroup[0].BodyTypeMeshes.Length - 1)
            {
                _eyesIndex = 0;
            }
            else
            {
                _eyesIndex++;
            }

            SetAppearance();
            UpdateIndexText();
        }

        public void SetEyesPrev()
        {
            if (_eyesIndex <= 0)
            {
                _eyesIndex = _selectedActorAttributesDatabase.EyesAttributesGroup[0].BodyTypeMeshes.Length - 1;
            }
            else
            {
                _eyesIndex--;
            }

            SetAppearance();
            UpdateIndexText();
        }

        public void SetHeadNext()
        {
            if (_headIndex >= _selectedActorAttributesDatabase.HeadAttributesGroup[0].BodyTypeMeshes.Length - 1)
            {
                _headIndex = 0;
            }
            else
            {
                _headIndex++;
            }

            SetAppearance();
            UpdateIndexText();
        }

        public void SetHeadPrev()
        {
            if (_headIndex <= 0)
            {
                _headIndex = _selectedActorAttributesDatabase.HeadAttributesGroup[0].BodyTypeMeshes.Length - 1;
            }
            else
            {
                _headIndex--;
            }

            SetAppearance();
            UpdateIndexText();
        }

        public void SetAppearance()
        {
            _hairMesh.mesh = _selectedActorAttributesDatabase.HairAttributesGroup[0].BodyTypeMeshes[_hairIndex];
            _eyesMesh.mesh = _selectedActorAttributesDatabase.EyesAttributesGroup[0].BodyTypeMeshes[_eyesIndex];
            _headMesh.mesh = _selectedActorAttributesDatabase.HeadAttributesGroup[0].BodyTypeMeshes[_headIndex];
            _bodyMesh.sharedMesh = _selectedActorAttributesDatabase.BodyAttributesGroup[0].BodyTypeMeshes[_bodyIndex];

            if (_hairIndex == 0 && _eyeBrows.activeInHierarchy != true)
            {
                _eyeBrows.SetActive(true);
            }
            else
            {
                _eyeBrows.SetActive(false);
            }
        }

        public void UpdateIndexText()
        {
            _eyesIndexText.SetText(_eyesIndex.ToString());
            _hairIndexText.SetText(_hairIndex.ToString());
            _headIndexText.SetText(_headIndex.ToString());
        }
    }
}
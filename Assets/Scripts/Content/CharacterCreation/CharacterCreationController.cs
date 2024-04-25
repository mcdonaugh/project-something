using ProjectSomething.Data;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ProjectSomething.Content.CharacterCreation
{
    public class CharacterCreationController : MonoBehaviour
    {
        [SerializeField] private GameObject _playerCustomizationModel;
        [SerializeField] private ActorAttributesDatabase _ActorAttributesDatabase;
        [SerializeField] private MeshFilter _eyesMesh;
        [SerializeField] private MeshFilter _hairMesh;
        [SerializeField] private MeshFilter _headMesh;
        [SerializeField] private SkinnedMeshRenderer _bodyMesh;
        [SerializeField] private GameObject _eyeBrows;
        [SerializeField] private TMP_Text _hairIndexText;
        [SerializeField] private TMP_Text _eyesIndexText;
        [SerializeField] private TMP_Text _headIndexText;
        [SerializeField] private PlayerSelectedActorAttributes _playerSelectedActorAttributes;
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
            if (_hairIndex >= _ActorAttributesDatabase.HairAttributesGroup.BodyTypeMeshes.Length - 1)
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
                _hairIndex = _ActorAttributesDatabase.HairAttributesGroup.BodyTypeMeshes.Length - 1;
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
            if (_eyesIndex >= _ActorAttributesDatabase.EyesAttributesGroup.BodyTypeMeshes.Length - 1)
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
                _eyesIndex = _ActorAttributesDatabase.EyesAttributesGroup.BodyTypeMeshes.Length - 1;
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
            if (_headIndex >= _ActorAttributesDatabase.HeadAttributesGroup.BodyTypeMeshes.Length - 1)
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
                _headIndex = _ActorAttributesDatabase.HeadAttributesGroup.BodyTypeMeshes.Length - 1;
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
            _hairMesh.mesh = _ActorAttributesDatabase.HairAttributesGroup.BodyTypeMeshes[_hairIndex];
            _eyesMesh.mesh = _ActorAttributesDatabase.EyesAttributesGroup.BodyTypeMeshes[_eyesIndex];
            _headMesh.mesh = _ActorAttributesDatabase.HeadAttributesGroup.BodyTypeMeshes[_headIndex];
            _bodyMesh.sharedMesh = _ActorAttributesDatabase.BodyAttributesGroup.BodyTypeMeshes[_bodyIndex];

            if (_hairIndex == 0)
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
        
        public void ConfirmSelection()
        {
            _playerSelectedActorAttributes.SetHairIndex(_hairIndex);
            _playerSelectedActorAttributes.SetEyesIndex(_eyesIndex);
            _playerSelectedActorAttributes.SetHeadIndex(_headIndex);
            _playerSelectedActorAttributes.SetBodyIndex(_bodyIndex);
            SceneManager.LoadScene("MainScene");
        }
    }
}
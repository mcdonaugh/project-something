using UnityEngine;

namespace ProjectSomething.Data
{
    [CreateAssetMenu(fileName = "New Player Selected Actor Attributes", menuName = "Create Data / New Player Selected Actor Attribute")]
    public class PlayerSelectedActorAttributes : ScriptableObject
    {
        public int HairIndex => _hairIndex;
        public int EyesIndex => _eyesIndex;
        public int HeadIndex => _headIndex;
        public int BodyIndex => _bodyIndex;
        private int _hairIndex = 0;
        private int _eyesIndex = 0;
        private int _headIndex = 0;
        private int _bodyIndex = 0;

        public void SetHairIndex(int index)
        {
            _hairIndex = index;
        }

        public void SetEyesIndex(int index)
        {
            _eyesIndex = index;
        }

        public void SetHeadIndex(int index)
        {
            _headIndex = index;
        }

        public void SetBodyIndex(int index)
        {
            _bodyIndex = index;
        }
    }   
}

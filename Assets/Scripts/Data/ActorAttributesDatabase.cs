using UnityEngine;

namespace ProjectSomething.Data
{
    [CreateAssetMenu(fileName = "New Actor Attributes Database", menuName = "Create Data/ New Actor Attribute Database")]
    public class ActorAttributesDatabase : ScriptableObject
    {
        public ActorAttributes HairAttributesGroup => _hairAttributesGroup;
        public ActorAttributes HeadAttributesGroup => _headAttributesGroup; 
        public ActorAttributes EyesAttributesGroup => _eyesAttributesGroup; 
        public ActorAttributes BodyAttributesGroup => _bodyAttributesGroup;   

        [Header("Hair")]
        [SerializeField] private ActorAttributes _hairAttributesGroup;

        [Header("Head")]
        [SerializeField] private ActorAttributes _headAttributesGroup;

        [Header("Eyes")]
        [SerializeField] private ActorAttributes _eyesAttributesGroup;

        [Header("Body")]
        [SerializeField] private ActorAttributes _bodyAttributesGroup;
    }    
}

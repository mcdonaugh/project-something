using UnityEngine;

namespace ProjectSomething.Data
{
    [CreateAssetMenu(fileName = "New Actor Attributes Database", menuName = "Create Data/ New Actor Attribute Database")]
    public class ActorAttributesDatabase : ScriptableObject
    {
        public ActorAttributes[] ActorAttributesGroup => _actorAttributesGroup;  

        [Header("Actor Attributes")]
        [SerializeField] private ActorAttributes[] _actorAttributesGroup;
    }    
}

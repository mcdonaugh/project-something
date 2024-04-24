using UnityEngine;

namespace ProjectSomething.Data
{
    [CreateAssetMenu(fileName = "New Actor Attributes", menuName = "Create Data/ New Actor Attribute")]
    public class ActorAttributes : ScriptableObject
    {
        public Mesh[] BodyTypeMeshes => _bodyTypeMeshes;
        [SerializeField] private Mesh[] _bodyTypeMeshes;
    }   
}
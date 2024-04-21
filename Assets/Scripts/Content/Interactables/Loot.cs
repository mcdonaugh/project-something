using ProjectSomething.Interfaces;
using UnityEngine;

namespace ProjectSomething.Content.Interactables
{
    public class Loot : MonoBehaviour, IInteractable
    {
        private Rigidbody _rigidBody;

        private void Awake()
        {
            _rigidBody = GetComponent<Rigidbody>();
        }
        public void Interact()
        {
            PickupItem();
        }

        public void PickupItem()
        {
            Debug.Log("Pickup");
            _rigidBody.AddForce(Vector3.forward * 10, ForceMode.Impulse);
        }
    }
}

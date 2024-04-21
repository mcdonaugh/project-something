using ProjectSomething.Interfaces;
using UnityEngine;

namespace ProjectSomething.Content.Interactables
{
    public class Chest : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            DestroyChest();
        }

        private void DestroyChest()
        {
            Destroy(gameObject);
        }
    }
}

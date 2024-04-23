using ProjectSomething.Interfaces;
using UnityEngine;

namespace ProjectSomething.Content.Interactables
{
    public class Chest : MonoBehaviour, IInteractable
    {
        private Animator _animator;
        private bool _isOpen = false;
        private void Awake()
        {
            _animator = GetComponent<Animator>();    
        }
        public void Interact()
        {
            OpenChest();
        }

        private void OpenChest()
        {
            if (!_isOpen)
            {
                _animator.Play("ChestOpen");
            }
            else
            {
                _animator.Play("ChestClose");
            }
        }

        public void SetChestStateEnabled()
        {
            _isOpen = true;
        }

        public void SetChestStateDisabled()
        {
            _isOpen = false;
        }
    }
}

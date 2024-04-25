using UnityEngine;
using ProjectSomething.Controllers;
using ProjectSomething.Interfaces;

namespace ProjectSomething.Player
{
    public class PlayerController : ActorController
    {
        private IInteractable _interactable = null;
        
        new private PlayerInputController _input = new PlayerInputController();
        private void Update()
        {
            if(_input.InteractionKeyPressed() && _interactable != null)
            {
                _animator.Play("Interact");
                _interactable.Interact();
            }  
        }

        private void OnTriggerEnter(Collider other)
        {
            IInteractable interactable = other.transform.GetComponent<IInteractable>();
            
            if (interactable != null)
            {
                _interactable = interactable;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            _interactable = null;
        }
    }
}
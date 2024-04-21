using UnityEngine;
using ProjectSomething.Controllers;
using ProjectSomething.Interfaces;
using System.Collections;

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
                ChangeAnimation("Interact");
                _interactable.Interact();
                ChangeAnimation("Idle");
            }  
        }

        private void OnTriggerEnter(Collider other)
        {
            IInteractable interactable = other.transform.GetComponent<IInteractable>();
            
            if (interactable != null)
            {
                _interactable = interactable;
                Debug.Log(_interactable);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            _interactable = null;
        }
    }
}
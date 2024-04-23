using ProjectSomething.Player;
using UnityEngine;

namespace ProjectSomething.GameStates
{
    public class StateStart : StateMachineBehaviour
    {
        [SerializeField] private PlayerController _playerController;

        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            _playerController = animator.transform.parent.GetComponent<PlayerController>();
            Debug.Log(animator.transform.parent.name);
            // animator.speed = -1;
            // Debug.Log($"{animator.name}, {stateInfo.speed}, {layerIndex}");
            // Debug.Log(animator.GetCurrentAnimatorStateInfo(layerIndex).IsName(animator.name));
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Input Logged");
            }
        }
    }   
}
using UnityEngine;
using ProjectSomething.Interfaces;

namespace ProjectSomething.Player
{
    public class PlayerInputController : IInput
    {
        public Vector2 GetAxisInput()
        {
            Vector2 input = new Vector2();

            if (Input.GetKey(KeyCode.W))
            {
                input = new Vector2(input.x,1);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                input = new Vector2(input.x,-1);
            }
            else
            {
                input = new Vector2(input.x,0);
            }
            
            if (Input.GetKey(KeyCode.A))
            {
                input = new Vector2(-1,input.y);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                input = new Vector2(1,input.y);
            }
            else
            {
                input = new Vector2(0,input.y);
            }

            return input.normalized;
        }

        public bool InteractionKeyPressed()
        {
            return Input.GetKeyDown(KeyCode.E);
        }

        public void EnableCursor()
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        public void DisableCursor()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
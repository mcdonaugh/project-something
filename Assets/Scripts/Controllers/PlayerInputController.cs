using UnityEngine;

namespace ProjectSomething.Interfaces
{
    public class PlayerInputController : IInput
    {
        public Vector2 GetInput()
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
    }
}
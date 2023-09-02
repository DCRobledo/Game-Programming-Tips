using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Command
{
    public class PlayerMovement : EntityMovement
    {
        public Command jumpButton;

        private void Start() 
        {
            jumpButton = new JumpCommand();
        }

        private void Update() 
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                jumpButton.Execute();
            }
        }
    }
}
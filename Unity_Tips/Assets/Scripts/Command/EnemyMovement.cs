using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Command
{
    public class EnemyMovement : EntityMovement
    {
        public Command jumpButton;

        private void Start() 
        {
            jumpButton = new JumpCommand();
        }

        private void Update() 
        {
            if(CheckWall())
            {
                jumpButton.Execute();
            }
        }

        private bool CheckWall()
        {
            // Check if an enemy is walking towards a wall

            return true;
        }
    }
}
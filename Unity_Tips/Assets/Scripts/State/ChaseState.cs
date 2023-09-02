using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.State
{
    public class ChaseState : IGhostState
    {
        public IGhostState DoState(Ghost ghost)
        {
            ChasePlayer();

            if(ghost.IsFrightened())
            {
                return ghost.EscapeState;
            }

            else if(ghost.IsChaseTimeOver())
            {
                return ghost.WanderState;
            }

            return ghost.ChaseState;
        }

        private void ChasePlayer()
        {
            // Chase the player
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.State
{
    public class EscapeState : IGhostState
    {
        public IGhostState DoState(Ghost ghost)
        {
            EscapeFromPlayer();

            if(ghost.IsFrightened())
            {
                return ghost.EscapeState;
            }

            return ghost.ChaseState;
        }

        private void EscapeFromPlayer()
        {
            // Flee from player
        }
    }
}
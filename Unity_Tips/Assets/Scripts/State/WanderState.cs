using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.State
{
    public class WanderState : IGhostState
    {
        public IGhostState DoState(Ghost ghost)
        {
            WanderAround();

            if(ghost.IsFrightened())
            {
                return ghost.EscapeState;
            }

            else if(ghost.IsWanderTimeOver())
            {
                return ghost.ChaseState;
            }

            return ghost.WanderState;
        }

        private void WanderAround()
        {
            // Wander to the map's edges
        }
    }
}
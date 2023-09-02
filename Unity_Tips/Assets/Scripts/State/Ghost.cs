using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.State
{
    public class Ghost : MonoBehaviour
    {
        private IGhostState _currentState;

        public ChaseState ChaseState = new ChaseState();
        public WanderState WanderState = new WanderState();
        public EscapeState EscapeState = new EscapeState();


        private void Awake() 
        {
            _currentState = ChaseState;
        }

        private void Update() 
        {
            _currentState = _currentState.DoState(this);
        }

        public bool IsFrightened()
        {
            // Check if the ghost is frightened or not

            return false;
        }

        public bool IsChaseTimeOver()
        {
            // Check if the ghost should keep chasing or not

            return false;
        }

        public bool IsWanderTimeOver()
        {
            // Check if the ghost should keep wandering or not

            return false;
        }
    }
}
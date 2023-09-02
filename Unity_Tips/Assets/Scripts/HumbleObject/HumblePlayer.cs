using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.HumbleObject
{
    public class HumblePlayer : MonoBehaviour, IPlayer
    {
        private PlayerMovement _playerMovement;

        [SerializeField]
        private float horizontalMaxLimit = 5f;
        [SerializeField]
        private float horizontalMinLimit = -5f;

        public float HorizontalMaxLimit { get { return horizontalMaxLimit; } }
        public float HorizontalMinLimit { get { return horizontalMinLimit; } }

        public Vector3 Position { get { return transform.position; } set { transform.position = value; } }


        private void Awake() 
        {
            _playerMovement = new PlayerMovement(this);
        }


        private void Update() 
        {
            _playerMovement.Move(Input.GetAxis("Horizontal"));    
        }
    }
}
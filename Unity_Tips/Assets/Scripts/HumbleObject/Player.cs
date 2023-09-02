using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.HumbleObject
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private float horizontalMaxLimit = 5f;

        [SerializeField]
        private float horizontalMinLimit = -5f;


        private void Update() 
        {
            Move(Input.GetAxis("Horizontal"));    
        }


        private void Move(float direction)
        {
            transform.position += Vector3.right * direction;

            if(transform.position.x > horizontalMaxLimit)
            {
                transform.position = new Vector3(horizontalMaxLimit, transform.position.y, transform.position.z);
            }

            if(transform.position.x < horizontalMinLimit)
            {
                transform.position = new Vector3(horizontalMinLimit, transform.position.y, transform.position.z);
            }
        }
    }
}
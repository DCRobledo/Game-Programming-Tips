using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Features.SceneStreaming
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField]
        private float speed = 5f;

        private Rigidbody _rigidbody;

        private void Start() 
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            _rigidbody.velocity = movement * speed;
        }
    }
}
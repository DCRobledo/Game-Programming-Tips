using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tips.SOLID
{
    public class BadPlayerMovement : MonoBehaviour
    {
        [SerializeField]
        private float moveSpeed = 5f;
        [SerializeField]
        private float jumpForce = 5f;
        [SerializeField]
        private float dashForce = 10f;

        private Rigidbody2D _rigidBody2D;


        private void Awake()
        {
            _rigidBody2D = GetComponent<Rigidbody2D>();
        }


        public void Move(float direction)
        {
            _rigidBody2D.velocity = new Vector2(direction * moveSpeed, _rigidBody2D.velocity.y);
        }

        public void Jump()
        {
            _rigidBody2D.AddForce(new Vector2(_rigidBody2D.velocity.x, jumpForce), ForceMode2D.Impulse);
        }

        public void Dash(float direction)
        {
            _rigidBody2D.AddForce(new Vector2(direction * dashForce, 0), ForceMode2D.Impulse);
        }
    }
}
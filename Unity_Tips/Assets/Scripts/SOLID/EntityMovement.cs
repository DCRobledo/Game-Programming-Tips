using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tips.SOLID
{
    public abstract class EntityMovement : MonoBehaviour
    {
        [SerializeField]
        protected float moveSpeed = 5f;
        [SerializeField]
        protected float jumpForce = 5f;
        [SerializeField]
        protected float dashForce = 10f;

        protected Rigidbody2D _rigidBody2D;


        private void Awake()
        {
            _rigidBody2D = GetComponent<Rigidbody2D>();
        }

        public virtual void Move(float direction)
        {
            _rigidBody2D.velocity = new Vector2(direction * moveSpeed, _rigidBody2D.velocity.y);
        }

        public virtual void Jump()
        {
            _rigidBody2D.AddForce(new Vector2(_rigidBody2D.velocity.x, jumpForce), ForceMode2D.Impulse);
        }

        public virtual void Dash(float direction) {}
    }
}
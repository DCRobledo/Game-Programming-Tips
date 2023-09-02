using System;
using System.Collections;
using UnityEngine;

namespace Tips.SOLID
{
    public class BadPlayerController : MonoBehaviour
    {
        private bool _isJumping = false;
        private bool _isDashing = false;

        private IInput _inputHandler;

        private BadPlayerMovement _playerMovement;


        private void Awake() 
        {
            _playerMovement = GetComponent<BadPlayerMovement>();
        }


        private void Update()
        {
            // Move player horizontally
            float moveX = _inputHandler.MoveDirection();
            _playerMovement.Move(moveX);

            // Jump
            if (_inputHandler.IsJump() && !_isJumping)
            {
                _playerMovement.Jump();
                _isJumping = true;
            }

            // Dash
            if (_inputHandler.IsDash() && !_isDashing)
            {
                float dashDirection = Mathf.Sign(moveX);
                _playerMovement.Dash(dashDirection);
                _isDashing = true;
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            // Check if player is grounded
            if (collision.gameObject.CompareTag("Ground"))
            {
                _isJumping = false;
                _isDashing = false;
            }
        }
    }
}
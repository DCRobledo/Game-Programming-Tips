using System;
using System.Collections.Generic;
using UnityEngine;

namespace Tips.SOLID
{
    public class PlayerController : MonoBehaviour
    {
        private bool _isJumping = false;
        private bool _isDashing = false;

        private IPlayerInput _inputHandler;

        private EntityMovement _playerMovement;

        private void Awake() 
        {
            _playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<EntityMovement>();
        }

        private void OnEnable() 
        {
            PlayerCollisions.OnGround += OnPlayerGrounded;
        }

        private void OnDisable() 
        {
            PlayerCollisions.OnGround -= OnPlayerGrounded;
        }

        private void Update()
        {
            OnMove();

            if (_inputHandler.IsJump() && !_isJumping)
            {
                OnJump();
            }

            if (_inputHandler.IsDash() && !_isDashing)
            {
                OnDash();
            }
        }


        private void OnMove()
        {
            float moveDirection = _inputHandler.MoveDirection();
            _playerMovement.Move(moveDirection);
        }

        private void OnJump()
        {
            _playerMovement.Jump();
            _isJumping = true;
        }

        private void OnDash()
        {
            float moveDirection = _inputHandler.MoveDirection();
            _playerMovement.Dash(Mathf.Sign(moveDirection));
            _isDashing = true;
        }

        private void OnPlayerGrounded()
        {
            _isJumping = false;
            _isDashing = false;
        }
    }
}
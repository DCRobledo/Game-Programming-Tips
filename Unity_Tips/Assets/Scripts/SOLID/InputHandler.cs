using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tips.SOLID
{
    public class InputHandler : MonoBehaviour, IInput, IPlayerInput
    {
        public float MoveDirection()
        {
            return Input.GetAxis("Horizontal");
        }

        public bool IsJump()
        {
            return Input.GetButtonDown("Jump");
        }

        public bool IsDash()
        {
            return Input.GetButtonDown("Dash");
        }

        public bool IsAttack()
        {
            return Input.GetButtonDown("Attack");
        }

        public bool IsRoll()
        {
            return Input.GetButtonDown("Roll");
        }
    }
}
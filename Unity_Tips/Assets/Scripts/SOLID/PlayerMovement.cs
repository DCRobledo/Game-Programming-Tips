using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tips.SOLID
{
    public class PlayerMovement : EntityMovement
    {
        public override void Dash(float direction)
        {
            _rigidBody2D.AddForce(new Vector2(direction * dashForce, 0), ForceMode2D.Impulse);

            base.Dash(direction);
        }
    }
}
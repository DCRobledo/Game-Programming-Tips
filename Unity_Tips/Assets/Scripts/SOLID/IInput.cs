using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tips.SOLID
{
    public interface IInput
    {
        float MoveDirection();

        bool IsJump();
        bool IsDash();

        bool IsAttack();
        bool IsRoll();
    }
}
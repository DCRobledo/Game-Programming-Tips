using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tips.SOLID
{
    public interface IPlayerInput
    {
        float MoveDirection();

        bool IsJump();
        bool IsDash();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Strategy
{
    public interface IAttackBehaviour
    {
        void Attack(int damage);
    }
}
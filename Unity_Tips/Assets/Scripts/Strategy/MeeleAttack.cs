using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Strategy
{
    public class MeeleAttack : IAttackBehaviour
    {
        public void Attack(int damage)
        {
            // Chase player and damage on contact
        }
    }
}
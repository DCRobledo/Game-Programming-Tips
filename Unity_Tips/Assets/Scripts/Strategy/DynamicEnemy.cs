using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Strategy
{
    public class DynamicEnemy : Enemy
    {
        private void Start()
        {
            _attackBehaviour = new MeeleAttack();

            TryAttack();
        }

        private void OnPlayerNear()
        {
            // When we are close to the player, we switch to the RangeAttack mode
            _attackBehaviour = new RangeAttack();

            TryAttack();
        }

        private void OnPlayerFar()
        {
            // When we are far from the player, we switch to the MeeleAttack mode
            _attackBehaviour = new MeeleAttack();

            TryAttack();
        }
    }
}
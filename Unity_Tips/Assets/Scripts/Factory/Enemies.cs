using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Factory
{
    public class Skull : IEnemy
    {
        public void Attack()
        {
            // TODO: Chase player
        }
    }

    public class Demon : IEnemy
    {
        public void Attack()
        {
            // TODO: Shoot at player
        }
    }

    public class Angel : IEnemy
    {
        public void Attack()
        {
            // TODO: Heal enemies
        }
    }
}
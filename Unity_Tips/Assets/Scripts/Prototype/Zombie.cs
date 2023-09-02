using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Prototype
{
    public class Zombie : Mob
    {
        public Zombie(int health) : base(health) {}

        public override Mob Clone()
        {
            return new Zombie(_health);
        }

        public override void Attack()
        {
            // Ride a pig and charge to player
        }
    }
}
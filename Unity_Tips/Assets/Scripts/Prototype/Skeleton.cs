using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Prototype
{
    public class Skeleton : Mob
    {
        public Skeleton(int health) : base(health) {}

        public override Mob Clone()
        {
            return new Skeleton(_health);
        }

        public override void Attack()
        {
            // Shoot arrows to player
        }
    }
}
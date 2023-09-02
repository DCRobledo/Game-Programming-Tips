using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Prototype
{
    public class Creeper : Mob
    {
        public Creeper(int health) : base(health) {}

        public override Mob Clone()
        {
            return new Creeper(_health);
        }

        public override void Attack()
        {
            // Get near player and then explode
        }
    }
}
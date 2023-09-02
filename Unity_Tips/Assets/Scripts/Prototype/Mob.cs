using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Prototype
{
    public abstract class Mob
    {
        protected int _health;

        public Mob(int health)
        {
            _health = health;
        }

        public abstract Mob Clone();

        public abstract void Attack();
    }
}
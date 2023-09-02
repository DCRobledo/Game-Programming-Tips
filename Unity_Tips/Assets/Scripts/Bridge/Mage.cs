using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Bridge
{
    public class Mage : ICompanion
    {
        public void Attack()
        {
            // Throw fireball
        }

        public void Flee()
        {
            // Teleport to nearest roof
        }

        public void Help()
        {
            // Cast healing spell
        }

        public void Run()
        {
            // Open portal into enemies
        }
    }
}
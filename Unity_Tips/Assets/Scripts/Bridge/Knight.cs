using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Bridge
{
    public class Knight : ICompanion
    {
        public void Attack()
        {
            // Swing sword
        }

        public void Flee()
        {
            // Cover behind nearest wall
        }

        public void Help()
        {
            // Protect with shield
        }

        public void Run()
        {
            // Charge with horse
        }
    }
}
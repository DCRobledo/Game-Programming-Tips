using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Bridge
{
    public class DefensiveBehaviour : FightingBehaviour
    {
        public override void Fight()
        {
            _companion.Flee();

            _companion.Help();
        }
    }
}
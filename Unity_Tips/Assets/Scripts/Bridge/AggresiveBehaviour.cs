using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Bridge
{
    public class AggresiveBehaviour : FightingBehaviour
    {
        public override void Fight()
        {
            _companion.Run();

            _companion.Attack();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator
{
    public class EnemyHelmet : EnemyDecorator
    {
        public EnemyHelmet(Enemy decoratorOwner) : base(decoratorOwner)
        {
            
        }

        public override void ReceiveDamage(float damagePoints, bool isHeadDamage = false)
        {
            if(!isHeadDamage)
            {
                base.ReceiveDamage(damagePoints);
            }
        }
    }
}
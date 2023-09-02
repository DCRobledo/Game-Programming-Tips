using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator
{
    public class EnemyChestPlate : EnemyDecorator
    {
        public EnemyChestPlate(Enemy decoratorOwner) : base(decoratorOwner)
        {
            
        }

        public override void ReceiveDamage(float damagePoints, bool isHeadDamage = false)
        {
            base.ReceiveDamage(damagePoints / 2f);
        }
    }
}
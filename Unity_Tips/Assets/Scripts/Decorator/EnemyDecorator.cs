using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator
{
    public class EnemyDecorator : Enemy
    {
        protected Enemy _decoratorOwner;


        public EnemyDecorator(Enemy decoratorOwner)
        {
            _decoratorOwner = decoratorOwner;
        }


        public override void ReceiveDamage(float damagePoints, bool isHeadDamage = false)
        {
            _decoratorOwner.ReceiveDamage(damagePoints);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator
{
    public class Enemy : MonoBehaviour
    {
        private float _health;
        private float _damage;

        public virtual void ReceiveDamage(float damagePoints, bool isHeadDamage = false)
        {
            _health -= damagePoints;

            if(_health <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            Destroy(gameObject);
        }
    }
}
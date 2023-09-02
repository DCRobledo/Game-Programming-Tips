using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Strategy
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField]
        protected int damage;

        protected IAttackBehaviour _attackBehaviour;


        public void TryAttack()
        {
            _attackBehaviour?.Attack(damage);
        }

        public void SetAttackBehaviour(IAttackBehaviour attackBehaviour)
        {
            _attackBehaviour = attackBehaviour;
        }
    }
}
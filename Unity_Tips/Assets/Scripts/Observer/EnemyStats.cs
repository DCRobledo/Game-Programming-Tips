using System;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Observer
{
    public class EnemyStats : MonoBehaviour
    {
        private float health;

        private int scorePoints;

        public static Action<int> enemyDeathEvent;


        private void OnEnemyHit(int damagePoints)
        {
            health -= damagePoints;

            if(health <= 0)
            {
                enemyDeathEvent?.Invoke(scorePoints); // invoke death event
            }
        }
    }
}

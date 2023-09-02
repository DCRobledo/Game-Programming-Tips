using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Factory
{
    public class EnemyController : MonoBehaviour
    {
        public static EnemyController instance;

        private IEnemyFactory enemyFactory;


        private void Awake() 
        {
            instance = this;
        }

        private void Update() {
            if(ShouldSpawnEnemy())
            {
                SpawnEnemy(enemyFactory.CreateEnemy());
            }
        }


        public void SetEnemyFactory(IEnemyFactory enemyFactory)
        {
            this.enemyFactory = enemyFactory;
        }

        private void SpawnEnemy(IEnemy enemy)
        {
            // TODO
        }

        private bool ShouldSpawnEnemy()
        {
            // TODO
            return false;
        }
    }
}


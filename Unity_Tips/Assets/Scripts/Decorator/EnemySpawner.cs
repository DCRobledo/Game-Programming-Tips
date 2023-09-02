using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject enemyPrefab;

        private float _helmetChance = .2f;
        private float _chestPlateChance = .4f;


        private void SpawnEnemy()
        {
            GameObject enemyGO = Instantiate(enemyPrefab);

            Enemy enemy = enemyGO.GetComponent<Enemy>();

            if(Random.Range(0, 10) < _chestPlateChance)
            {
                var enemyWithChestplate = new EnemyChestPlate(enemy);

                enemy = enemyWithChestplate;
            }

            if(Random.Range(0, 10) < _helmetChance)
            {
                var enemyWithHelmet = new EnemyHelmet(enemy);

                enemy = enemyWithHelmet;
            }
        }
    }
}
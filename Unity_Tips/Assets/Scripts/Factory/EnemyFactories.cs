using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Factory
{
    public class EasyEnemyFactory : IEnemyFactory
    {
        public IEnemy CreateEnemy()
        {
            int rnd = Random.Range(0, 100);

            if(rnd < 50)
            {
                return new Skull();
            }

            else
            {
                return new Demon();
            }
        }
    }

    public class MediumEnemyFactory : IEnemyFactory
    {
        public IEnemy CreateEnemy()
        {
            int rnd = Random.Range(0, 100);

            if(rnd < 10)
            {
                return new Skull();
            }

            else if(rnd < 50)
            {
                return new Demon();
            }

            else
            {
                return new Angel();
            }
        }
    }

    public class HardEnemyFactory : IEnemyFactory
    {
        public IEnemy CreateEnemy()
        {
            int rnd = Random.Range(0, 100);

            if(rnd < 33)
            {
                return new Skull();
            }

            else if(rnd < 66)
            {
                return new Demon();
            }

            else
            {
                return new Angel();
            }
        }
    }
}

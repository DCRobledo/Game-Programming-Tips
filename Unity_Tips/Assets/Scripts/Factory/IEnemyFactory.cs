using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Factory
{
    public interface IEnemyFactory
    {
        public IEnemy CreateEnemy();
    }
}

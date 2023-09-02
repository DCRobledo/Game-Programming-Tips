using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Factory
{
    public class PlayerController : MonoBehaviour
    {
        public static PlayerController instance;

        private int playerLevel;

        
        private void Awake() 
        {
            instance = this;
        }


        private void OnPlayerLevelUp()
        {
            if(playerLevel > 5)
            {
                EnemyController.instance.SetEnemyFactory(new MediumEnemyFactory());
            }

            else if(playerLevel > 10)
            {
                EnemyController.instance.SetEnemyFactory(new HardEnemyFactory());
            }
        }
    }
}

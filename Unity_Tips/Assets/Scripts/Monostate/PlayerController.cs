using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Monostate
{
    public class PlayerController : MonoBehaviour
    {
        private PlayerStats playerStats;

        private void Start() 
        {
            playerStats = new PlayerStats();
        }

        private void OnPlayerHit()
        {
            playerStats.lifes--;

            if(playerStats.lifes <= 0)
            {
                GameOver();
            }
        }

        private void GameOver()
        {
            // End the game
        }
    }
}

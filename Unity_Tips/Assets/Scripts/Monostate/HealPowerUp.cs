using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Monostate
{
    public class HealPowerUp : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other) 
        {
            if(other.tag.Equals("Player"))
            {
                PlayerStats playerStats = new PlayerStats();

                playerStats.lifes++;

                Destroy(this.gameObject);
            }
        }
    }
}
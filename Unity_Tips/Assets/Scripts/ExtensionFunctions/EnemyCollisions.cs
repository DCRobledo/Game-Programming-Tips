using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils.ExtensionFunctions
{
    public class EnemyCollisions : MonoBehaviour
    {
        private int health = 10;

        private void OnTriggerEnter2D(Collider2D other) 
        {
            if(other.tag.Equals("PlayerProjectile"))
            {
                int damagePoints = other.GetComponent<ProjectileStats>().GetDamagePoints();

                health -= damagePoints;

                if(health <= 0)
                {
                    Die();
                }
            }
        }

        private void Die()
        {
            this.transform.Reset();

            this.gameObject.SetActive(false);
        }
    }
}
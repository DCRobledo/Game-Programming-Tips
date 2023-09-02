using System;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.ServiceLocator
{
    public class PlayerCollisions : MonoBehaviour
    {
        public static Action OnPlayerHit;

        private void OnCollisionEnter2D(Collision2D other) 
        {
            if(other.gameObject.tag.Equals("Enemy"))
            {
                AudioLocator.GetAudioService().PlaySound("PlayerHit");

                OnPlayerHit?.Invoke();
            }
        }
    }
}
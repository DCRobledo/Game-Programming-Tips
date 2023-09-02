using System;
using System.Collections.Generic;
using UnityEngine;

namespace Tips.SOLID
{
    public class PlayerCollisions : MonoBehaviour
    {
        public static Action OnGround;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                OnGround?.Invoke();
            }
        }
    }
}
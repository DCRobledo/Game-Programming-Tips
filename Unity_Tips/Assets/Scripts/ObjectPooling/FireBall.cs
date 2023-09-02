using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.ObjectPooling
{
    public class FireBall : MonoBehaviour
    {
        private FireBallPoll _fireBallPool;


        private void Start()
        {
            _fireBallPool = FindObjectOfType<FireBallPoll>();    
        }

        private void OnDisable() 
        {
            _fireBallPool?.EnqueueFireBall(gameObject);
        }


        public void Init()
        {
            transform.position = FindObjectOfType<Player>().gameObject.transform.position;
        }

        private void OnCollisionEnter2D(Collision2D other) 
        {
            if(other.gameObject.tag == "Wall" || other.gameObject.tag == "Enemy")
            {
                gameObject.SetActive(false);
            }
        }
    }
}
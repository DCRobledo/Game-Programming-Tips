using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.ObjectPooling
{
    public class Player : MonoBehaviour
    {
        private FireBallPoll _fireBallPool;


        private void Start()
        {
            _fireBallPool = FindObjectOfType<FireBallPoll>();    
        }

        private void Update() 
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                GameObject fireBall = _fireBallPool.GetFireBall();

                fireBall.GetComponent<FireBall>().Init();
            }    
        }
    }
}
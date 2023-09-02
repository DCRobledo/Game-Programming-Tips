using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.ObjectPooling
{
    public class FireBallPoll : MonoBehaviour
    {
        [SerializeField]
        private GameObject fireBallPrefab;

        [SerializeField]
        private Queue<GameObject> fireBallPool = new Queue<GameObject>();

        [SerializeField]
        private int startSize = 10;


        private void Start() 
        {
            for(int i = 0; i < startSize; ++i)
            {
                EnqueueFireBall(Instantiate(fireBallPrefab));
            }
        }


        public GameObject GetFireBall()
        {
            GameObject fireBall = IsEmpty() ? Instantiate(fireBallPrefab) : fireBallPool.Dequeue();

            fireBall.SetActive(true);

            return fireBall;
        }

        public void EnqueueFireBall(GameObject fireBall)
        {
            fireBallPool.Enqueue(fireBall);

            fireBall.SetActive(false);
        }

        public bool IsEmpty()
        {
            return fireBallPool.Count <= 0;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tips.LegibleCode
{
    public class LegibleCodeExamples : MonoBehaviour
    {
        public int PlayerLifes; 

        private bool _canShoot;
        private bool _canDash;

        [SerializeField]
        private GameObject projectilePrefab;

        private void FixedUpdate() 
        {
            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                if(_canShoot)
                {
                    CreateAProjectile();
                }
            }
        }

        private void CreateAProjectile()
        {
            GameObject myProjectile = GameObject.Instantiate(this.projectilePrefab); // Mal

            var myOtherProjectile = GameObject.Instantiate(projectilePrefab); // Bien
        }

        private void CheckPlayerLifes()
        {
            if(PlayerLifes <= 0)
            {
                StartCoroutine(GameOverCoroutine());
            } 
        }

        private IEnumerator GameOverCoroutine()
        {
            yield return new WaitForSeconds(1f);

            Application.Quit();
        }

        private void Update() 
        {
            if(_canDash)
            {
                Dash();
            }
        }

        private void Dash() {}
    }
}
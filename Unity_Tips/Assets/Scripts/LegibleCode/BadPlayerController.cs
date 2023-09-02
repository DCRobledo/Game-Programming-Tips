using System;
using System.Collections;
using UnityEngine;

namespace Tips.LegibleCode
{
    public class BadPlayerController : MonoBehaviour
    {
        [Header("Movement Settings")]

        [SerializeField]
        private int speed = 50;

        [SerializeField]
        private float smoothingFactor = .3f;

        private Vector2 velocity = Vector2.zero;

        private Rigidbody2D rigidBody;

        private Vector2 movingDirection;

        [Header("Dash Settings")]

        [SerializeField]
        private int dashPower = 100;

        [SerializeField]
        private float dashDuration = 0.2f;
        
        [SerializeField]
        private float dashCooldown = 1f;

        private bool dash = true;
        private bool dashing = false;

        public static Action dashEvent;

        [Header("Shoot Settings")]

        [SerializeField]
        private GameObject projectile;

        private bool shoot = true;

        private float shootCooldown = .5f;

        public static Action shootEvent;


        private void Awake() 
        {
            this.rigidBody = GetComponent<Rigidbody2D>();
        }


        private void Update() 
        {
            // Register WASD movement
            if(Input.GetKeyDown(KeyCode.W)){
                this.movingDirection.y = 1f;
            }
            if(Input.GetKeyDown(KeyCode.A)){
                this.movingDirection.x = -1f;
            }
            if(Input.GetKeyDown(KeyCode.S)){
                this.movingDirection.y = 1f;
            }
            if(Input.GetKeyDown(KeyCode.D)){
                this.movingDirection.x = 1f;
            }

            // Register shoot button
            if(Input.GetKeyDown(KeyCode.Mouse0)){
                Shoot();
            }

            // Register dash button
            if(Input.GetKeyDown(KeyCode.Mouse1)){
                Dash();
            }
        }

        private void FixedUpdate() 
        {
            // Move the player
            Move(this.movingDirection);
        }

        private void Move(Vector2 movingDirection)
        {
            if(!this.dashing){
                // Smooth velocity
                Vector2 smoothedVelocity = Vector2.SmoothDamp(Vector2.zero, new Vector2(movingDirection.x, movingDirection.y), ref velocity, this.smoothingFactor);

                // Apply it to the rigid body
                this.rigidBody.velocity = smoothedVelocity * this.speed;
            }
        }


        private void Dash()
        {
            if(this.dash){
                this.dash = false;
                this.dashing = true;

                // Increase current rigidbody velocity
                this.rigidBody.velocity += this.rigidBody.velocity * (this.dashPower / 100);

                StartCoroutine(DashExecution());

                dashEvent?.Invoke();
            }
        }

        private IEnumerator DashExecution()
        {
            yield return new WaitForSeconds(dashDuration);

            this.dashing = false;

            StartCoroutine(DashCooldown());
        }

        private IEnumerator DashCooldown()
        {
            yield return new WaitForSeconds(dashCooldown);

            this.dash = true;
        }


        private void Shoot(bool normalize = true)
        {
            if(this.shoot){
                this.shoot = false;

                // Transform mouse position to world space
                Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                // Compute aim direction
                Vector3 aim = mouse - this.transform.position;

                if(normalize)
                {
                    aim.Normalize();
                }

                // Instantiate the projectile and set its target direction
                GameObject projectile = GameObject.Instantiate(this.projectile, this.transform.position, Quaternion.identity);
                projectile.GetComponent<ProjectileMovement>().SetTargetDirection(aim);

                shootEvent?.Invoke();

                StartCoroutine(ShootCooldown());
            }
        }

        private IEnumerator ShootCooldown()
        {
            yield return new WaitForSeconds(shootCooldown);

            this.shoot = true;
        }
    }
}
using System;
using System.Collections;
using UnityEngine;

namespace Tips.LegibleCode
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Movement Settings")]

        [SerializeField]
        private int speed = 50;

        [SerializeField]
        private float smoothingFactor = .3f;

        private Vector2 _velocity = Vector2.zero;

        private Rigidbody2D _rigidBody;

        private Vector2 _movingDirection;

        [Header("Dash Settings")]

        [SerializeField]
        private int dashPower = 100;

        [SerializeField]
        private float dashDurationInSeconds = 0.2f;
        
        [SerializeField]
        private float dashCooldownInSeconds = 1f;

        private bool _canDash = true;
        private bool _isDashing = false;

        public static Action OnDash;

        [Header("Shoot Settings")]

        [SerializeField]
        private GameObject projectilePrefab;

        private bool _canShoot = true;

        private float _shootCooldownInSeconds = .5f;

        public static Action OnShoot;


        private void Awake() 
        {
            _rigidBody = GetComponent<Rigidbody2D>();
        }


        private void Update() 
        {
            HandleMovementInput();

            HandleShootInput();

            HandleDashInput();
        }

        private void HandleMovementInput()
        {
            if(Input.GetKeyDown(KeyCode.W))
            {
                _movingDirection.y = 1f;
            }
            if(Input.GetKeyDown(KeyCode.A))
            {
                _movingDirection.x = -1f;
            }
            if(Input.GetKeyDown(KeyCode.S))
            {
                _movingDirection.y = 1f;
            }
            if(Input.GetKeyDown(KeyCode.D))
            {
                _movingDirection.x = 1f;
            }
        }

        private void HandleShootInput()
        {
            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                if(_canShoot)
                {
                    Shoot();
                }
            }
        }

        private void HandleDashInput()
        {   
            if(Input.GetKeyDown(KeyCode.Mouse1))
            {
                if(_canDash)
                {
                    Dash();
                }
            }
        }


        private void FixedUpdate() 
        {
            if(!_isDashing)
            {
                Move(_movingDirection);
            }
        }


        private void Move(Vector2 movingDirection)
        {
            var smoothedVelocity = Vector2.SmoothDamp
            (
                Vector2.zero,
                new Vector2(movingDirection.x, movingDirection.y),
                ref _velocity,
                smoothingFactor
            );

            _rigidBody.velocity = smoothedVelocity * speed;
        }


        private void Dash()
        {
            _canDash = false;
            _isDashing = true;

            _rigidBody.velocity += _rigidBody.velocity * (dashPower / 100);

            StartCoroutine(DashExecutionCoroutine());

            OnDash?.Invoke();
        }

        private IEnumerator DashExecutionCoroutine()
        {
            yield return new WaitForSeconds(dashDurationInSeconds);

            _isDashing = false;

            StartCoroutine(DashCooldownCoroutine());
        }

        private IEnumerator DashCooldownCoroutine()
        {
            yield return new WaitForSeconds(dashCooldownInSeconds);

            _canDash = true;
        }


        private void Shoot()
        {
            _canShoot = false;

            Vector2 aimDirection = GetAimDirection();

            var projectile = GameObject.Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            projectile.GetComponent<ProjectileMovement>().SetTargetDirection(aimDirection);

            OnShoot?.Invoke();

            StartCoroutine(ShootCooldownCoroutine());
        }

        private IEnumerator ShootCooldownCoroutine()
        {
            yield return new WaitForSeconds(_shootCooldownInSeconds);

            _canShoot = true;
        }
    
        private Vector3 GetAimDirection(bool normalize = true)
        {
            Vector3 mousePositionInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector3 aimDirection = mousePositionInWorld - transform.position;

            if(normalize)
            {
                aimDirection.Normalize();
            }

            return aimDirection;
        }
    }
}
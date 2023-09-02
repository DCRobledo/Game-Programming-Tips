using UnityEngine;

namespace Tips.ObjectOrientedProgramming
{
    // Template class used to create objects
    public class Enemy
    {
        private string _enemyName;
            
        private int _health;
        private int _damage;
            
        public Enemy(string enemyName, int health, int damage)
        {
            _enemyName = enemyName;
            _health = health;
            _damage = damage;
        }
            
        public void Attack()
        {
            Debug.Log($"{_enemyName} attacks for {_damage} damage points!");
        }
    
    }
}
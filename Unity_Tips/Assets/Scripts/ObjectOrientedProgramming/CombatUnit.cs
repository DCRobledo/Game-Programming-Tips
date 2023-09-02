using UnityEngine;

namespace Tips.ObjectOrientedProgramming
{
    public class CombatUnit : Unit
    {
        private int _damage;

        public CombatUnit(string unitName, int health, int damage) : base(unitName, health)
        {
            _damage = damage;
        }

        public void Attack()
        {
            Debug.Log($"{_unitName} attacks for {_damage} damage points");
        }
    }
}
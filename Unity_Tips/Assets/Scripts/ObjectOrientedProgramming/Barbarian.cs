using UnityEngine;

namespace Tips.ObjectOrientedProgramming
{
    public class Barbarian : Character
    {
        private int _damage;

        public Barbarian(string characterName, int health, int damage) : base(characterName, health)
        {
            _damage = damage;
        }

        public override void PerformAction()
        {
            Debug.Log($"{_characterName} spins around for {_damage} damage points");
        }
    }
}
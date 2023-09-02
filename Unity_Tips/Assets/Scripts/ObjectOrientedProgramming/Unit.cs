using UnityEngine;

namespace Tips.ObjectOrientedProgramming
{
    public class Unit
    {
        protected string _unitName;

        protected int _health;
        protected int _movementRange;

        public Unit() { }

        public Unit(string unitName, int health)
        {
            _unitName = unitName;
            _health = health;
        }

        public void Move(Vector3 destination)
        {
            Debug.Log($"{_unitName} moves to {destination}");
        }

        public int Health
        {
            get => _health;
            set => _health = value;
        }
    }
}
using UnityEngine;

namespace Tips.ObjectOrientedProgramming
{
    public class Mage : Character
    {
        private int _teleportDistance;

        public Mage(string characterName, int health, int teleportDistance) : base(characterName, health)
        {
            _teleportDistance = teleportDistance;
        }

        public override void PerformAction()
        {
            Debug.Log($"{_characterName} teleports to {_teleportDistance} meters");
        }
    }
}
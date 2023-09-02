using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Builder
{
    public class Tarnished : MonoBehaviour
    {
        private Dictionary<ArmorLocations, Armor> armor;
        private Weapon weapon;
        private int health;

        public void SetComponents(Dictionary<ArmorLocations, Armor> armor, Weapon weapon, int health)
        {
            this.armor = armor;
            this.weapon = weapon;
            this.health = health;
        }
    }
}
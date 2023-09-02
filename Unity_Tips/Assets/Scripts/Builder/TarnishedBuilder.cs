using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Builder
{
    public class TarnishedBuilder
    {
        private Dictionary<ArmorLocations, Armor> armor = new Dictionary<ArmorLocations, Armor>();
        private Weapon weapon;
        private int health = 10;

        private Tarnished tarnished;


        public TarnishedBuilder WithArmor(ArmorLocations armorLocation, Armor armor)
        {
            this.armor.Add(armorLocation, armor);

            return this;
        }

        public TarnishedBuilder WithWeapon(Weapon weapon)
        {
            this.weapon = weapon;

            return this;
        }

        public TarnishedBuilder WithHealth(int health)
        {
            this.health = health;

            return this;
        }

        public TarnishedBuilder FromTarnishedPrefab(Tarnished tarnished)
        {
            this.tarnished = tarnished;

            return this;
        }


        public Tarnished Build()
        {   
            // Instantiate the tarnished
            Tarnished tarnished = GameObject.Instantiate(this.tarnished);

            // Instantiate the armor
            Dictionary<ArmorLocations, Armor> armor = new Dictionary<ArmorLocations, Armor>();

            foreach(var armorPiece in this.armor)
            {
                Armor m_Armor = GameObject.Instantiate(armorPiece.Value, tarnished.transform);
                armor.Add(armorPiece.Key, m_Armor);
            }

            // Instantiate the weapon
            Weapon weapon = GameObject.Instantiate(this.weapon, tarnished.transform);

            // Set tarnished's components
            tarnished.SetComponents(armor, weapon, this.health);

            // Return the built tarnished
            return tarnished;
        }
    }
}

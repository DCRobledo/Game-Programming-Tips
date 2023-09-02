using System;
using UnityEngine;

namespace Tips.ObjectOrientedProgramming
{
    public class GameController : MonoBehaviour
    {
        private void Start()
        {
            // An actual object instance of the Enemy class
            Enemy enemy = new Enemy("Silksong", 10, 300);
            
            // Pick an item from the inventory without knowing how it is implemented
            Inventory inventory = new Inventory();
            UnityEngine.Object pokeball = inventory.PickItem("Pokeball");
            
            // Create two units, both can move but they also can perform different actions based on their type
            CombatUnit combatUnit = new CombatUnit("Peashooter", 20, 10);
            combatUnit.Move(Vector3.zero);
            combatUnit.Attack();

            SupportUnit supportUnit = new SupportUnit("Sunflower", 5, 15);
            supportUnit.Move(Vector3.zero);
            supportUnit.Heal(combatUnit);
            
            // Create two characters and execute their actions, they will do different things based on their type
            Barbarian barbarian = new Barbarian("The Warth", 100, 50);
            barbarian.PerformAction(); // Spins around

            Mage mage = new Mage("Triss", 10, 200);
            mage.PerformAction(); // Teleports
        }
    }
}
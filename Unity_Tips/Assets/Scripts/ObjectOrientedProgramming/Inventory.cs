using System.Collections.Generic;
using UnityEngine;

namespace Tips.ObjectOrientedProgramming
{
    public class Inventory
    {
        private List<Object> _inventory;

        public Object PickItem(string itemName)
        {
            foreach (var item in _inventory)
            {
                if (item.name.Equals(itemName))
                {
                    return item;
                }
            }

            return null;
        }

        public void AddItem(Object item)
        {
            _inventory.Add(item);
        }
    }
}
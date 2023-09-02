using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils.ExtensionFunctions
{
    public class ProjectileStats : MonoBehaviour
    {
        private int damagePoints = 5;

        public int GetDamagePoints()
        {
            return this.damagePoints;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Builder
{
    public abstract class Weapon : MonoBehaviour
    {
        protected abstract void Attack();
    }
}
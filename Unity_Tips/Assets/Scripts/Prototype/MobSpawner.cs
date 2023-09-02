using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Prototype
{
    public class MobSpawner
    {
        private Mob _prototype;

        public MobSpawner(Mob prototype)
        {
            _prototype = prototype;
        }

        public Mob SpawnMob()
        {
            return _prototype.Clone();
        }
    }
}
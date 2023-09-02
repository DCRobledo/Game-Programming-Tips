using System;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Prototype
{
    public class SpawnerController : MonoBehaviour
    {
        public static SpawnerController Instance;

        private Dictionary<Type, MobSpawner> _mobSpawners = new Dictionary<Type, MobSpawner>();


        private void Awake() 
        {
            Instance = this;
        }

        private void Start() 
        {
            CreateMobSpawner(new Creeper(15));

            CreateMobSpawner(new Skeleton(8));

            CreateMobSpawner(new Zombie(30));
        }


        private void CreateMobSpawner(Mob mob)
        {
            MobSpawner mobSpawner = new MobSpawner(mob);

            if(!_mobSpawners.TryGetValue(typeof(Mob), out mobSpawner))
            {
                _mobSpawners.Add(typeof(Mob), mobSpawner);
            }
        }

        private Mob SpawnMob<T>()
        {
            MobSpawner mobSpawner;

            if(!_mobSpawners.TryGetValue(typeof(Mob), out mobSpawner))
            {
                mobSpawner = new MobSpawner(new Creeper(10));
            }

            return mobSpawner.SpawnMob();
        }
    }
}
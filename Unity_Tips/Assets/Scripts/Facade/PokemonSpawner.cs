using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Facade
{
    public class PokemonSpawner : MonoBehaviour
    {
        public static PokemonSpawner instance;

        private void Awake() 
        {
            instance = this;
        }

        public void SpawnPokemonInBattle(GameObject pokemon)
        {
            // Spawn a pokemon in battle mode
        }

        public void DespawnAllPokemonsInBattle()
        {
            // Destroy all active pokemons
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Facade
{
    public class PokemonBattleFacade : MonoBehaviour
    {
        public static PokemonBattleFacade instance;

        private void Awake() 
        {
            instance = this;
        }

        public void StartPokemonBattle(GameObject enemyPokemon, string battleType)
        {
            // Transition to battle mode
            ScreenSwitcher.instance.SwitchScreen(battleType);

            // Show battle UI
            PokemonBattleUI.instance.ShowBattleUI();

            // Spawn ally and enemy pokemons
            PokemonSpawner.instance.SpawnPokemonInBattle(PlayerController.instance.GetFirstPokemon());
            PokemonSpawner.instance.SpawnPokemonInBattle(enemyPokemon);
        }

        public void EndPokemonBattle()
        {
            // Transition to exploration mode
            ScreenSwitcher.instance.SwitchScreen("Exploration");

            // Hide battle UI
            PokemonBattleUI.instance.HideBattleUI();

            // Destroy pokemons
            PokemonSpawner.instance.DespawnAllPokemonsInBattle();
        }
    }
}
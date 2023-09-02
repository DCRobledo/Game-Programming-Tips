using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Facade
{   
    public class PokemonTrainer : MonoBehaviour
    {
        private List<GameObject> pokemonTeam = new List<GameObject>();

        private void OnPlayerContact()
        {
            PokemonBattleFacade.instance.StartPokemonBattle(this.GetFirstPokemon(), "PokemonTrainerBattle");
        }

        private void OnOutOfPokemons()
        {
            PokemonBattleFacade.instance.EndPokemonBattle();
        }

        public GameObject GetFirstPokemon()
        {
            return pokemonTeam[0];
        }
    }
}
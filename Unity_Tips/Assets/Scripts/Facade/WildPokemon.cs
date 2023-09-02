using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Facade
{
    public class WildPokemon : MonoBehaviour
    {
        private void OnGrassChance()
        {
            PokemonBattleFacade.instance.StartPokemonBattle(this.gameObject, "WildPokemonBattle");
        }

        private void OnOutOfHealth()
        {
            PokemonBattleFacade.instance.EndPokemonBattle();
        }
    }
}
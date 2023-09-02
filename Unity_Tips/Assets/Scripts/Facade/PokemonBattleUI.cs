using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Facade
{
    public class PokemonBattleUI : MonoBehaviour
    {
        public static PokemonBattleUI instance;

        private void Awake() 
        {
            instance = this;
        }

        public void ShowBattleUI()
        {
            // Show the User Interface for the pokemon battle
        }

        public void HideBattleUI()
        {
            // Hide the User Interface for the pokemon battle
        }
    }
}
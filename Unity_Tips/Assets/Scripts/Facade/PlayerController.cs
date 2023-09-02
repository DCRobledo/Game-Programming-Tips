using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Facade
{
    public class PlayerController : MonoBehaviour
    {
        public static PlayerController instance;

        private List<GameObject> pokemonTeam = new List<GameObject>();

        private void Awake() 
        {
            instance = this;
        }

        public GameObject GetFirstPokemon()
        {
            return pokemonTeam[0];
        }
    }
}

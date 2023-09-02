using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Features.SaveSystem
{
    public class PlayerStats : MonoBehaviour
    {
        [SerializeField]
        private string playerName;

        [SerializeField]
        private int health;

        [SerializeField]
        private float mana;


        private void Update() 
        {
            if(Input.GetKeyDown(KeyCode.S))
            {
                SaveHandler.SaveData(this, "./Saves/PlayerStats.data");
            }

            if(Input.GetKeyDown(KeyCode.L))
            {
                PlayerStatsData loadedData = SaveHandler.LoadData("./Saves/PlayerStats.data");

                playerName = loadedData.GetPlayerName();
                health = loadedData.GetHealth();
                mana = loadedData.GetMana();
            }
        }


        public string GetPlayerName()
        {
            return playerName;
        }

        public int GetHealth()
        {
            return health;
        }

        public float GetMana()
        {
            return mana;
        }
    }
}
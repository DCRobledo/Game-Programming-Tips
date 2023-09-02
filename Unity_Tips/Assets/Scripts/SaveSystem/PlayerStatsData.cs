using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Features.SaveSystem
{
    [System.Serializable]
    public class PlayerStatsData
    {
        private string playerName;
        private int health;
        private float mana;

        public PlayerStatsData(PlayerStats playerStats)
        {
            playerName = playerStats.GetPlayerName();
            health = playerStats.GetHealth();
            mana = playerStats.GetMana();
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

        public new string ToString()
        {
            return $"Player Name = {playerName}, Health = {health}, Mana = {mana}";
        }
    }
}
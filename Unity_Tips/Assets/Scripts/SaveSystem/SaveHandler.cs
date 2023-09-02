using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

namespace Features.SaveSystem
{
    public static class SaveHandler
    {
        public static void SaveData(PlayerStats playerStats, string path)
        {
            PlayerStatsData playerStatsData = new PlayerStatsData(playerStats);


            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path, FileMode.Create);

            formatter.Serialize(stream, playerStatsData);

            stream.Close();


            string formatedLoadedData = playerStatsData.ToString();

            Debug.Log($"SAVED: {formatedLoadedData}");
        }

        public static PlayerStatsData LoadData(string path)
        {
            if(File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                FileStream stream = new FileStream(path, FileMode.Open);

                PlayerStatsData playerStatsData = formatter.Deserialize(stream) as PlayerStatsData;

                stream.Close();


                string formatedLoadedData = playerStatsData.ToString();

                Debug.Log($"LOADED: {formatedLoadedData}");


                return playerStatsData;
            }

            else
            {
                Debug.LogError($"ERROR: SaveHandle couldn't find {path}");

                return null;
            }
        }
    }
}
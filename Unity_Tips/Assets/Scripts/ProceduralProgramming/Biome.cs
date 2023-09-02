using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tips.ProceduralProgramming
{
    [CreateAssetMenu(fileName = "Biome", menuName = "ScriptableObject/Biome")]
    public class Biome : ScriptableObject
    {
        public float _height;        
        public float _temperature;   

        public Sprite Tile;

        public bool IsValid(float height, float temperature)
        {
            return height >= _height && temperature >= _temperature;
        }

        public float GetDiff(float height, float temperature)
        {
            return (height - _height) + (temperature - _temperature);
        }
    }         
}
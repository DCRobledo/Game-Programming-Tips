using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tips.ProceduralProgramming
{
    public class MapGenerator : MonoBehaviour
    {
        [SerializeField]
        private Biome[] biomes;

        [SerializeField]
        private GameObject tilePrefab;

        [SerializeField]
        private int width = 256;
        [SerializeField]
        private int height = 256;
        [SerializeField]
        private float scale = 1.0f;

        [SerializeField]
        private Wave[] heightWaves;
        [SerializeField]
        private Wave[] temperatureWaves;

        private float[,] _heightMap;
        private float[,] _temperatureMap;


        private void Start() 
        {
            GenerateMap();
        }


        private void GenerateMap()
        {
            _heightMap = NoiseGenerator.GenerateNoiseMap(width, height, scale, heightWaves);

            _temperatureMap = NoiseGenerator.GenerateNoiseMap(width, height, scale, temperatureWaves);

            for(int x = 0; x < width; ++x)
            {
                for(int y = 0; y < height; ++y)
                {
                    GameObject tile = Instantiate(tilePrefab, new Vector3(x * 14, y * 14, 0), Quaternion.identity);

                    tile.GetComponent<SpriteRenderer>().sprite = GetBiome(_heightMap[x, y], _temperatureMap[x, y]).Tile;
                }
            }
        }

        private Biome GetBiome(float height, float temperature)
        {
            List<Biome> possibleBiomes = GetPossibleBiomes(height, temperature);

            Biome targetBiome = biomes[0];
            float diffValue = targetBiome.GetDiff(height, temperature);

            foreach(Biome biome in possibleBiomes)
            {
                if(biome.GetDiff(height, temperature) < diffValue)
                {
                    targetBiome = biome;
                }

                diffValue = biome.GetDiff(height, temperature);
            }

            return targetBiome;
        }

        private List<Biome> GetPossibleBiomes(float height, float temperature)
        {
            List<Biome> possibleBiomes = new List<Biome>();

            foreach(Biome biome in biomes)
            {
                if(biome.IsValid(height, temperature))
                {
                    possibleBiomes.Add(biome);
                }
            }
            
            return possibleBiomes;
        }
    }
}
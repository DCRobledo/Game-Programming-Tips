using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tips.ProceduralProgramming
{
    public class NoiseGenerator
    {
        public static float [,] GenerateNoiseMap(int width, int height, float scale, Wave[] waves, bool debug = false)
        {
            float[,] noiseMap = new float[width, height];

            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < width; ++x)
                {
                    float sampleX = (float) x * scale;
                    float sampleY = (float) y * scale;

                    float normalization = 0.0f;

                    foreach(Wave wave in waves)
                    {
                        noiseMap[x, y] += wave.Amplitude * Mathf.PerlinNoise(sampleX * wave.Frequency + wave.Seed, sampleY * wave.Frequency + wave.Seed);
                        normalization += wave.Amplitude;
                    }

                    noiseMap[x, y] /= normalization;

                    if(debug)
                    {
                        float noiseValue = noiseMap[x, y];
                        
                        Debug.Log($"[{x}, {y}] = {noiseValue}");
                    }
                }
            }

            return noiseMap;
        }
    }
}